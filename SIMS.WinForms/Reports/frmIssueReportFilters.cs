using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using BusinessLogic.Reports;
using DVLD.WinForms.Utils;
using Microsoft.Reporting.WinForms;

namespace SIMS.WinForms.Reports
{
    public partial class frmIssueReportFilters : Form
    {
        private string _ReportName;
        public frmIssueReportFilters(string reportName)
        {
            InitializeComponent();
            _ReportName = reportName;
        }

        private void frmIssueReportFilters_Load(object sender, EventArgs e)
        {
            if (_ReportName.Contains("مبيعات"))
            {
                clsFormHelper.InitializeDateRangeLimits(dtpDateFrom, dtpDateTo, clsSaleInvoice.GetFirstSaleInvoiceDate());
            }
            else
            {
                clsFormHelper.InitializeDateRangeLimits(dtpDateFrom, dtpDateTo, clsPurchaseInvoice.GetFirstPurchaseInvoiceDate());
            }

            cbRange.SelectedIndex = 2;
            lblReportName.Text = _ReportName;
        }

        private void cbRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ReportName.Contains("مبيعات"))
            {
                clsFormHelper.InitializeAndApplyDateRange(dtpDateFrom, dtpDateTo, cbRange, clsSaleInvoice.GetFirstSaleInvoiceDate());
            }
            else
            {
                clsFormHelper.InitializeAndApplyDateRange(dtpDateFrom, dtpDateTo, cbRange, clsPurchaseInvoice.GetFirstPurchaseInvoiceDate());
            }
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpDateTo.MinDate = dtpDateFrom.Value;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssueReport_Click(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;

            frmReportViewer reportViewerForm = new frmReportViewer();
            reportViewerForm.Controls.Add(reportViewer);

            if (_ReportName.Contains("مبيعات"))
            {
                reportViewer.LocalReport.ReportEmbeddedResource = "SIMS.WinForms.Reports.repSales.rdlc";

                List<clsBasicSalesReport> basicSalesReport = new List<clsBasicSalesReport>
                {
                    new clsBasicSalesReport(dtpDateFrom.Value, dtpDateTo.Value)
                };

                reportViewer.LocalReport.SetParameters(_GetParameters(basicSalesReport[0]));
                
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("BasicSalesReport", basicSalesReport));
            }
            else
            {
                reportViewer.LocalReport.ReportEmbeddedResource = "SIMS.WinForms.Reports.repPurchases.rdlc";

                List<clsBasicPurchasesReport> basicPurchasesReport = new List<clsBasicPurchasesReport>
                {
                    new clsBasicPurchasesReport(dtpDateFrom.Value, dtpDateTo.Value)
                };

                reportViewer.LocalReport.SetParameters(_GetParameters(basicPurchasesReport[0]));

                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("BasicPurchasesReport", basicPurchasesReport));
            }

            reportViewer.LocalReport.DisplayName = _ReportName;
            reportViewer.RefreshReport();
            reportViewerForm.ShowDialog();
        }

        private List<ReportParameter> _GetParameters(clsReport report)
        {
            return new List<ReportParameter>
            {
                new ReportParameter("DateFrom", report.DateFrom.ToString("yyyy/MM/dd")),
                new ReportParameter("DateTo", report.DateTo.ToString("yyyy/MM/dd")),
                new ReportParameter("IssuedEmployeeName", report.IssuedEmployeeName.EmployeeName),
                new ReportParameter("TodayDate", report.IssuedDate.ToString("yyyy/MM/dd HH:mm:ss")),
                new ReportParameter("CurrentYear", report.IssuedYear.ToString())
            };
        }

    }
}
