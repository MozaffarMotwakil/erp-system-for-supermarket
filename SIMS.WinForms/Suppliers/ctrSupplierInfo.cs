using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Interfaces;
using BusinessLogic.Invoices;
using BusinessLogic.Parties;
using BusinessLogic.Payments;
using BusinessLogic.Suppliers;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Interfaces;
using SIMS.WinForms.Invoices;
using SIMS.WinForms.Payments;
using SIMS.WinForms.Properties;
using SIMS.WinForms.Purchases;

namespace SIMS.WinForms.Suppliers
{
    public partial class ctrSupplierInfo : UserControl, IEntityView<clsSupplier>
    {
        public ctrSupplierInfo()
        {
            InitializeComponent();
        }

        public clsSupplier Entity
        {
            get
            {
                return _Supplier;
            }
            set
            {
                if (value is null)
                {
                    return;
                }

                _Supplier = value;
                lblNotes.Text = string.IsNullOrEmpty(_Supplier.Notes) ? "N/A" : _Supplier.Notes;

                switch (_Supplier.PartyInfo.PartyCategory)
                {
                    case clsParty.enPartyCategory.Person:
                        ctrOrganizationInfo.Visible = false;
                        ctrPersonInfo.Visible = true;
                        ctrPersonInfo.Person = _Supplier.PartyInfo as clsPerson;
                        lblNotesTitle.Location = new Point(703, 188);
                        lblNotes.Location = new Point(188, 188);
                        break;
                    case clsParty.enPartyCategory.Organization:
                        ctrPersonInfo.Visible = false;
                        ctrOrganizationInfo.Visible = true;
                        ctrOrganizationInfo.Organization = _Supplier.PartyInfo as clsOrganization;
                        lblNotesTitle.Location = new Point(lblNotesTitle.Location.X, 142);
                        lblNotes.Location = new Point(lblNotes.Location.X, 142);
                        break;
                    default:
                        this.Visible = false;
                        break;
                }

                tabControl.SelectedIndex = 0;
                _LoadDataForSuppliedProductsPage();
                _LoadDataForInvoicesPage();
                _LoadDataForPaymentPage();
            }
        }
        private clsSupplier _Supplier;
        private clsInvoice _SelectedInvoice
        {
            get
            {
                return _CurrentDGV.SelectedRows.Count != 0 ?
                    clsInvoiceService.CreateInstance().Find(Convert.ToInt32(_CurrentDGV?.SelectedRows[0]?.Cells["InvoiceID"].Value)) :
                    null;
            }
        }
        private DataGridView _CurrentDGV
        {
            get
            {
                return tabControl.SelectedTab == pageInvoices ?
                    dgvInvoices :
                    tabControl.SelectedTab == pagePayments ?
                    dgvPayments :
                    null;
            }
        }

        #region Control
        private void ShowInvoiceDetails_Click(object sender, EventArgs e)
        {
            clsInvoice invoice = _SelectedInvoice;

            if (invoice == null)
            {
                return;
            }

            frmShowInvoiceInfo showInvoiceInfo = new frmShowInvoiceInfo(invoice);
            showInvoiceInfo.ShowPartyInfo = false;
            showInvoiceInfo.ShowDialog();
        }

        private void ShowInvoiceInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    ShowInvoiceDetails_Click(sender, e);
                }
            }
        }

        private void SelectedCurrentRow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right && e.RowIndex >= 0)
            {
                (sender as DataGridView).Rows[e.RowIndex].Selected = true;
            }
        }

        private void ShowInvoiceInfo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.Button == MouseButtons.Right || (sender as DataGridView).SelectedRows.Count == 0)
            {
                return;
            }

            ShowInvoiceDetails_Click(sender, e);
        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormHelper.PreventContextMenuOnEmptyClick(_CurrentDGV, e);

            if (_CurrentDGV != null && _CurrentDGV.SelectedRows.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == pageSuppliedProducts)
            {
                dgvSuppliedProducts.ClearSelection();
            }
            else if (tabControl.SelectedTab == pagePayments)
            {
                dgvPayments.ClearSelection();
            }
        }
        #endregion Control

        #region PaymentPage
        private void _LoadDataForPaymentPage()
        {
            dgvPayments.DataSource = _Supplier.GetPayments();

            cbPaymentType.SelectedIndex = cbPaymentMethod.SelectedIndex = 0;
            cbPaymentsRange.SelectedIndex = 4;

            PaymentsContextMenuStrip.Items.Clear();

            PaymentsContextMenuStrip.Items.Add("عرض تفاصيل الفاتورة");
            PaymentsContextMenuStrip.Items[0].Click += ShowInvoiceDetails_Click;
            PaymentsContextMenuStrip.Items[0].Image = Resources.Invoice_32;
            PaymentsContextMenuStrip.Items[0].ImageScaling = ToolStripItemImageScaling.None;

            if (dgvPayments.Rows.Count > 0)
            {
                clsFormHelper.DisableSortableDataGridViewColumns(dgvPayments);

                cbPaymentsRange.Enabled = cbPaymentType.Enabled =
                    cbPaymentMethod.Enabled = txtSearch.Enabled = true;

                lblSearchHintText.BackColor = Color.White;

                dgvPayments.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Tahoma", 7, FontStyle.Bold);

                dgvPayments.DefaultCellStyle.Font =
                    new Font("Tahoma", 8);

                dgvPayments.Columns[0].HeaderText = "معرف المعاملة";
                dgvPayments.Columns[0].Width = 70;

                dgvPayments.Columns[1].HeaderText = "تاريخ المعاملة";
                dgvPayments.Columns[1].Width = 85;

                dgvPayments.Columns[2].HeaderText = "معرف الفاتورة";
                dgvPayments.Columns[2].Visible = false;

                dgvPayments.Columns[3].HeaderText = "رقم الفاتورة";
                dgvPayments.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvPayments.Columns[4].HeaderText = "إجمالي الفاتورة (جنيه)";
                dgvPayments.Columns[4].Width = 100;

                dgvPayments.Columns[5].HeaderText = "طريقة الدفع";
                dgvPayments.Columns[5].Width = 80;

                dgvPayments.Columns[6].HeaderText = "المبلغ المدفوع (جنيه)";
                dgvPayments.Columns[6].Width = 100;

                dgvPayments.Columns[7].HeaderText = "الرصيد التراكمي (جنيه)";
                dgvPayments.Columns[7].Width = 100;

                dgvPayments.Columns[8].HeaderText = "المبلغ المتبقي (جنيه)";
                dgvPayments.Columns[8].Width = 100;

                dgvPayments.Columns[9].HeaderText = "معرف نوع الفاتورة";
                dgvPayments.Columns[9].Visible = false;
            }
            else
            {
                cbPaymentsRange.Enabled = cbPaymentType.Enabled =
                    cbPaymentMethod.Enabled = txtSearch.Enabled = false;

                lblSearchHintText.BackColor = SystemColors.Control;
            }
        }

        private void dgvPayments_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            clsFormHelper.ApplyGreenRedRowStyle(dgvPayments, e, "InvoiceTypeID", 2, 1);
        }

        private void dgvPayments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblTotalPayments.Text = dgvPayments
                .Rows
                .Cast<DataGridViewRow>()
                .Where(row => (int)row.Cells["InvoiceTypeID"].Value == 1)
                .Sum(row => Convert.ToSingle(row.Cells["PaymentAmount"].Value))
                .ToString() + " جنيه";

            lblTotalReceipts.Text = dgvPayments
                .Rows
                .Cast<DataGridViewRow>()
                .Where(row => (int)row.Cells["InvoiceTypeID"].Value == 2)
                .Sum(row => Convert.ToSingle(row.Cells["PaymentAmount"].Value))
                .ToString() + " جنيه";
        }

        private void pictureBoxAndSearchHintText_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void cbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilterForPaymentsPage();
        }

        private void cbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilterForPaymentsPage();
        }

        private void cbPaymentsRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilterForPaymentsPage();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView currentDGV = _CurrentDGV;

            if (currentDGV.Rows.Count == 0) return;

            int currentIndex = currentDGV.SelectedRows.Count > 0 ? currentDGV.SelectedRows[0].Index : -1;
            int newIndex = currentIndex;

            if (e.KeyCode == Keys.Enter)
            {
                ShowInvoiceDetails_Click(currentDGV, e);
                e.Handled = true;
                return;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (currentIndex == currentDGV.Rows.Count - 1 || currentIndex == -1)
                {
                    newIndex = 0;
                }
                else
                {
                    newIndex = currentIndex + 1;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (currentIndex == 0 || currentIndex == -1)
                {
                    newIndex = currentDGV.Rows.Count - 1;
                }
                else
                {
                    newIndex = currentIndex - 1;
                }
            }
            else
            {
                return;
            }

            currentDGV.ClearSelection();
            currentDGV.Rows[newIndex].Selected = true;

            int firstVisibleRow = currentDGV.FirstDisplayedScrollingRowIndex;
            int displayedCount = currentDGV.DisplayedRowCount(false);
            int lastVisibleRow = firstVisibleRow + displayedCount - 1;

            if (newIndex > lastVisibleRow)
            {
                currentDGV.FirstDisplayedScrollingRowIndex = newIndex - displayedCount + 1;
            }
            else if (newIndex < firstVisibleRow)
            {
                currentDGV.FirstDisplayedScrollingRowIndex = newIndex;
            }

            e.Handled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblSearchHintText.Visible = string.IsNullOrEmpty(txtSearch.Text);
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void searchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            _ApplyFilterForPaymentsPage();
        }

        private void _ApplyFilterForPaymentsPage()
        {
            if (dgvPayments.DataSource == null || (dgvPayments.DataSource as DataTable).Rows.Count == 0)
            {
                return;
            }

            List<string> filters = new List<string>();
            DateTime range;

            if (cbPaymentType.SelectedIndex != 0)
            {
                filters.Add($"InvoiceTypeID = {cbPaymentType.SelectedIndex}");
            }

            if (cbPaymentMethod.SelectedIndex != 0)
            {
                filters.Add($"PaymentMethodName = '{cbPaymentMethod.Text}'");
            }

            if (cbPaymentsRange.SelectedIndex == 0)
            {
                range = DateTime.Now.AddDays(-1);
            }
            else if (cbPaymentsRange.SelectedIndex == 1)
            {
                range = DateTime.Now.AddDays(-7);
            }
            else if (cbPaymentsRange.SelectedIndex == 2)
            {
                range = DateTime.Now.AddMonths(-1);
            }
            else if (cbPaymentsRange.SelectedIndex == 3)
            {
                range = DateTime.Now.AddMonths(-6);
            }
            else
            {
                range = DateTime.Now.AddYears(-1);
            }

            filters.Add($"(PaymentDate >= #{range:yyyy-MM-dd}# AND PaymentDate <= #{DateTime.Now:yyyy-MM-dd}#)");

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                filters.Add($"InvoiceNa LIKE '%{txtSearch.Text}%'");
            }

            try
            {
                DataView payments = (dgvPayments.DataSource as DataTable).DefaultView;
                payments.RowFilter = string.Join(" AND ", filters);
            }
            catch
            {
                // في حال رمي إستثناء بسبب إدخال رموز غير صالحة فلا حاجة لعرض رسالة خطأ أو إيقاف تجربة المستخدم
            }
        }
        #endregion PaymentPage

        #region SuppliedProductsPage
        private void _LoadDataForSuppliedProductsPage()
        {
            DataTable suppliedProducts = _Supplier.GetAllProductsSupplied();

            dgvSuppliedProducts.ColumnHeadersDefaultCellStyle.Font =
                new Font("Tahoma", 7, FontStyle.Bold);

            dgvSuppliedProducts.DefaultCellStyle.Font =
                    new Font("Tahoma", 8);

            dgvSuppliedProducts.Rows.Clear();

            for (int i = 0; i < suppliedProducts.Rows.Count; i++)
            {
                dgvSuppliedProducts.Rows.Add();
                dgvSuppliedProducts.Rows[i].Cells[colNo.Index].Value = suppliedProducts.Rows[i]["No"];
                dgvSuppliedProducts.Rows[i].Cells[colProduct.Index].Value = suppliedProducts.Rows[i]["ProductName"];
                dgvSuppliedProducts.Rows[i].Cells[colUnit.Index].Value = suppliedProducts.Rows[i]["UnitName"];
                dgvSuppliedProducts.Rows[i].Cells[colLastPurchaseDataTime.Index].Value = (suppliedProducts.Rows[i]["LastPurchaseDate"] as DateTime?)?.ToString("dd/MM/yyyy") ?? "N/A";
                dgvSuppliedProducts.Rows[i].Cells[colLastPurchasePrice.Index].Value = suppliedProducts.Rows[i]["LastPurchasePrice"];
                dgvSuppliedProducts.Rows[i].Cells[colAveragePurchasePrice.Index].Value = suppliedProducts.Rows[i]["AveragePurchasePriceForLast12Month"];
                dgvSuppliedProducts.Rows[i].Cells[colTotalPurchases.Index].Value = suppliedProducts.Rows[i]["TotalPurchasesForLast12Month"];
                dgvSuppliedProducts.Rows[i].Cells[colTotalReturnPurchases.Index].Value = suppliedProducts.Rows[i]["TotalReturnPurchasesForLast12Month"];
            }
        }

        private void SuppliedItemsLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSuppliedProducts.SelectedRows.Count == 0)
            {
                return;
            }

            frmSuppliedItemsLogList suppliedItemsLogList = new frmSuppliedItemsLogList(
                    _Supplier.PartyInfo.PartyName,
                    Convert.ToString(dgvSuppliedProducts.SelectedRows[0].Cells[colProduct.Index].Value),
                    Convert.ToString(dgvSuppliedProducts.SelectedRows[0].Cells[colUnit.Index].Value)
                    );

            frmMainForm.OpenForm(suppliedItemsLogList);
        }

        private void SuppliesProductsContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormHelper.PreventContextMenuOnEmptyClick(dgvSuppliedProducts, e);

            if (_CurrentDGV != null && _CurrentDGV.SelectedRows.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void dgvSuppliedProducts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvSuppliedProducts.Rows[e.RowIndex].Selected = true;
            }
        }

        #endregion SuppliedProductsPage

        #region InvoicesPage
        private void _LoadDataForInvoicesPage()
        {
            dgvInvoices.DataSource = _Supplier.GetInvoices();

            cbInvoiceType.SelectedIndex = cbPaymentStatus.SelectedIndex = 0;
            cbInvoicesRange.SelectedIndex = 4;

            InvoicesContextMenuStrip.Items.Clear();

            InvoicesContextMenuStrip.Items.Add("عرض تفاصيل الفاتورة");
            InvoicesContextMenuStrip.Items[0].Click += ShowInvoiceDetails_Click;
            InvoicesContextMenuStrip.Items[0].Image = Resources.Invoice_32;
            InvoicesContextMenuStrip.Items[0].ImageScaling = ToolStripItemImageScaling.None;

            InvoicesContextMenuStrip.Items.Add("إصدار فاتورة مرتجعات");
            InvoicesContextMenuStrip.Items[1].Image = Resources.Invoice_32;
            InvoicesContextMenuStrip.Items[1].ImageScaling = ToolStripItemImageScaling.None;
            InvoicesContextMenuStrip.Items[1].Click += IssueReturnPurchaseInvoice_Click;
            clsInvoiceService.CreateInstance().EntitySaved += AfterIssueReturnInvoice_EntitySaved;

            InvoicesContextMenuStrip.Items.Add("إصدار مستند نقدي");
            InvoicesContextMenuStrip.Items[2].Image = Resources.payment_method;
            InvoicesContextMenuStrip.Items[2].ImageScaling = ToolStripItemImageScaling.None;
            InvoicesContextMenuStrip.Items[2].Click += IssuePayment_Click;
            clsPaymentService.CreateInstance().EntitySaved += AfterIssueNewPayment_EntitySaved;


            if (dgvInvoices.RowCount > 0)
            {
                clsFormHelper.DisableSortableDataGridViewColumns(dgvInvoices);

                cbInvoiceType.Enabled = cbPaymentStatus.Enabled =
                    cbInvoicesRange.Enabled = colPurchaseNo.Visible = true;

                dgvInvoices.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Tahoma", 7, FontStyle.Bold);

                dgvInvoices.DefaultCellStyle.Font =
                    new Font("Tahoma", 8);

                dgvInvoices.Columns[1].Visible = false;

                dgvInvoices.Columns[2].Visible = false;

                dgvInvoices.Columns[3].HeaderText = "نوع الحركة";
                dgvInvoices.Columns[3].Width = 85;

                dgvInvoices.Columns[4].HeaderText = "رقم الفاتورة";
                dgvInvoices.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvInvoices.Columns[5].HeaderText = "تاريخ المستند";
                dgvInvoices.Columns[5].Width = 100;

                dgvInvoices.Columns[6].Visible = false;

                dgvInvoices.Columns[7].Visible = false;

                dgvInvoices.Columns[8].HeaderText = "الإجمالي النهائي (جنيه)";
                dgvInvoices.Columns[8].Width = 110;

                dgvInvoices.Columns[9].HeaderText = "المبلغ المدفوع (جنيه)";
                dgvInvoices.Columns[9].Width = 110;

                dgvInvoices.Columns[10].HeaderText = "المبلغ المتبقي (جنيه)";
                dgvInvoices.Columns[10].Width = 110;
            }
            else
            {
                cbInvoiceType.Enabled = cbPaymentStatus.Enabled =
                    cbInvoicesRange.Enabled = colPurchaseNo.Visible = false;
            }
        }

        private void dgvInvoices_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvInvoices.Rows[e.RowIndex].Selected = true;
                dgvInvoices.Columns[e.ColumnIndex].Selected = true;
            }
        }

        private void AfterIssueReturnInvoice_EntitySaved(object sender, EntitySavedEventArgs e)
        {
            _LoadDataForInvoicesPage();
            _LoadDataForPaymentPage();
        }

        private void AfterIssueNewPayment_EntitySaved(object sender, EntitySavedEventArgs e)
        {
            _LoadDataForInvoicesPage();
            _LoadDataForPaymentPage();
        }

        private void IssueReturnPurchaseInvoice_Click(object sender, EventArgs e)
        {
            clsPurchaseInvoice invoice = _SelectedInvoice as clsPurchaseInvoice;

            if (invoice == null)
            {
                clsFormMessages.ShowError($"لم يتم العثور على الفاتورة");
                return;
            }

            if (!invoice.AreThereAnyItemsNotBeenReturned())
            {
                clsFormMessages.ShowError($"لا يمكن إصدار فاتورة مرتجعات جديدة, فقد تم بالفعل إرجاع كل البضاعة المشتراة في هذه الفاتورة");
                return;
            }

            frmIssuePurchaseReturnInvoice returnPurchaseInvoice = new frmIssuePurchaseReturnInvoice(invoice);
            returnPurchaseInvoice.ShowDialog();
        }

        private void IssuePayment_Click(object sender, EventArgs e)
        {
            clsPurchaseInvoice invoice = _SelectedInvoice as clsPurchaseInvoice;

            if (invoice == null)
            {
                clsFormMessages.ShowError($"لم يتم العثور على الفاتورة");
                return;
            }

            frmIssuePayment issuePayment = new frmIssuePayment(invoice);
            issuePayment.ShowDialog();
        }

        private void InvoicesContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            clsFormHelper.PreventContextMenuOnEmptyClick(_CurrentDGV, e);

            if (_CurrentDGV != null && _CurrentDGV.SelectedRows.Count == 0)
            {
                e.Cancel = true;
                return;
            }

            clsInvoice invoice = _SelectedInvoice;

            if (invoice == null)
            {
                return;
            }

            clsFormHelper.PreventContextMenuOnEmptyClick(dgvInvoices, e);
            InvoicesContextMenuStrip.Items[1].Visible = invoice.InvoiceType == enInvoiceType.Purchase;
            InvoicesContextMenuStrip.Items[2].Enabled = invoice.PaymentStatus != enPaymentStatus.Paid;
        }

        private void dgvInvoices_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow currentRow = dgvInvoices.Rows[e.RowIndex];
                currentRow.Cells[0].Value = e.RowIndex + 1;

                int invoiceTypeID = Convert.ToInt32(currentRow.Cells["InvoiceTypeID"].Value);
                int invoiceStatusID = Convert.ToInt32(currentRow.Cells["InvoiceStatusID"].Value);

                if (invoiceTypeID == 1 && invoiceStatusID == 1)
                {
                    currentRow.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
                    currentRow.DefaultCellStyle.ForeColor = Color.DarkGreen;
                }
                else if (invoiceTypeID == 1 && invoiceStatusID == 2)
                {
                    currentRow.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    currentRow.DefaultCellStyle.ForeColor = Color.DarkGoldenrod;
                }
                else if (invoiceTypeID == 1 && invoiceStatusID == 3)
                {
                    currentRow.DefaultCellStyle.BackColor = Color.LightCoral;
                    currentRow.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else
                {
                    currentRow.DefaultCellStyle.BackColor = Color.Gainsboro;
                    currentRow.DefaultCellStyle.ForeColor = Color.DimGray;
                }
            }
        }

        private void dgvInvoices_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvInvoices.ClearSelection();

            lblAmount.Text = dgvInvoices
                .Rows
                .Cast<DataGridViewRow>()
                .Where(row => (int)row.Cells["InvoiceTypeID"].Value == 1)
                .Sum(row => Convert.ToSingle(row.Cells["RemainingAmount"].Value))
                .ToString() + " جنيه";

            label3.Text = dgvInvoices
                .Rows
                .Cast<DataGridViewRow>()
                .Where(row => (int)row.Cells["InvoiceTypeID"].Value == 2)
                .Sum(row => Convert.ToSingle(row.Cells["RemainingAmount"].Value))
                .ToString() + " جنيه";
        }

        private void cbInvoiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilterForInvoicesPage();
        }

        private void cbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilterForInvoicesPage();
        }

        private void cbInvoicesRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilterForInvoicesPage();
        }

        private void _ApplyFilterForInvoicesPage()
        {
            if (dgvInvoices.DataSource == null || (dgvInvoices.DataSource as DataTable).Rows.Count == 0)
            {
                return;
            }

            List<string> filters = new List<string>();
            DataView invoices = (dgvInvoices.DataSource as DataTable).DefaultView;
            DateTime range;

            if (cbInvoiceType.SelectedIndex != 0)
            {
                filters.Add($"InvoiceTypeName = '{cbInvoiceType.Text}'");
            }

            if (cbPaymentStatus.SelectedIndex != 0)
            {
                filters.Add($"InvoiceStatusName = '{cbPaymentStatus.Text}'");
            }

            if (cbInvoicesRange.SelectedIndex == 0)
            {
                range = DateTime.Now.AddDays(-1);
            }
            else if (cbInvoicesRange.SelectedIndex == 1)
            {
                range = DateTime.Now.AddDays(-7);
            }
            else if (cbInvoicesRange.SelectedIndex == 2)
            {
                range = DateTime.Now.AddMonths(-1);
            }
            else if (cbInvoicesRange.SelectedIndex == 3)
            {
                range = DateTime.Now.AddMonths(-6);
            }
            else
            {
                range = DateTime.Now.AddYears(-1);
            }

            filters.Add($"(InvoiceDate >= #{range:yyyy-MM-dd}# AND InvoiceDate <= #{DateTime.Now:yyyy-MM-dd}#)");
            invoices.RowFilter = string.Join(" AND ", filters);
        }
        #endregion InvoicesPage

    }
}
