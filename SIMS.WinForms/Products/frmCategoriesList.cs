using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SIMS.WinForms.Products
{
    public partial class frmCategoriesList : BaseCategoriesForm
    {
        protected override Form EditEntityForm => new frmAddEditCategory(SelectedEntity);

        public frmCategoriesList()
        {
            InitializeComponent();
        }

        private void addCategoryToolStripButton_Click(object sender, EventArgs e)
        {
            frmAddEditCategory addCategory = new frmAddEditCategory();
            addCategory.ShowDialog();
        }

        private void frmCategoriesList_Load(object sender, EventArgs e)
        {
            cbCategoryActivity.SelectedIndex = 0;
        }

        protected override void LoadData()
        {
            base.LoadData();
            base.EntityName = "الفئة";
            base.IsEntitySupportActivityStatus = true;
        }

        private void cbCategoryActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            ApplySearchFilter();
        }

        protected override void ApplySearchFilter()
        {
            List<string> filters = new List<string>();

            if (cbCategoryActivity.SelectedIndex == 1)
            {
                filters.Add("IsActive = 1");
            }
            else if (cbCategoryActivity.SelectedIndex == 2)
            {
                filters.Add("IsActive = 0");
            }

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                filters.Add($"CategoryName LIKE '%{txtSearch.Text}%'");
            }

            base.Filter = string.Join(" AND ", filters);
            base.ApplySearchFilter();
        }

    }
}