using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Products;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Products
{
    public class BaseCategoriesForm : frmGenericListBase<clsCategoryService,  clsCategory>
    {
        public BaseCategoriesForm() : base(clsCategoryService.CreateInstance())
        {
            searchPanel.Location = new Point(540, searchPanel.Location.Y);
            dgvEntitiesList.Size = new Size(810, 310);
            dgvEntitiesList.Location = new Point(dgvEntitiesList.Location.X, 220);
            lblTotalRecords.Location = new Point(lblTotalRecords.Location.X, 425);
            lblTotalRecordsText.Location = new Point(lblTotalRecordsText.Location.X, 425);
        }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف الفئة";
                base.dgvEntitiesList.Columns[0].Visible = false;

                base.dgvEntitiesList.Columns[1].HeaderText = "إسم الفئة";
                base.dgvEntitiesList.Columns[1].Width = 250;

                base.dgvEntitiesList.Columns[2].HeaderText = "الوصف";
                base.dgvEntitiesList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                base.dgvEntitiesList.Columns[3].HeaderText = "عدد المنتجات داخل الفئة";
                base.dgvEntitiesList.Columns[3].Width = 120;

                base.dgvEntitiesList.Columns[4].HeaderText = "تاريخ الإنشاء";
                base.dgvEntitiesList.Columns[4].Width = 120;

                base.dgvEntitiesList.Columns[5].HeaderText = "حالة النشاط";
                base.dgvEntitiesList.Columns[5].Width = 80;
            }
        }

    }
}
