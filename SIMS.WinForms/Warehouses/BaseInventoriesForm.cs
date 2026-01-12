using System.Drawing;
using BusinessLogic.Warehouses;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Warehouses
{
    public class BaseInventoriesForm : frmGenericListBase<clsInventoryService, clsInventory>
    {
        public BaseInventoriesForm() : base(clsInventoryService.CreateInstance(), false)
        {
            dgvEntitiesList.Location = new Point(dgvEntitiesList.Location.X, 135);
            dgvEntitiesList.Height = 550;
            ShowSearchTextBox = false;
        }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف المخزون";
                base.dgvEntitiesList.Columns[0].Visible = false;

                base.dgvEntitiesList.Columns[1].HeaderText = "معرف المنتج";
                base.dgvEntitiesList.Columns[1].Visible = false;

                base.dgvEntitiesList.Columns[2].HeaderText = "المنتج";
                base.dgvEntitiesList.Columns[2].Width = 250;

                base.dgvEntitiesList.Columns[3].HeaderText = "الصنف/الفئة";
                base.dgvEntitiesList.Columns[3].Width = 150;

                base.dgvEntitiesList.Columns[4].HeaderText = "معرف الوحدة";
                base.dgvEntitiesList.Columns[4].Visible = false;

                base.dgvEntitiesList.Columns[5].HeaderText = "الوحدة";
                base.dgvEntitiesList.Columns[5].Width = 90;

                base.dgvEntitiesList.Columns[6].HeaderText = "معرف المخزن";
                base.dgvEntitiesList.Columns[6].Visible = false;

                base.dgvEntitiesList.Columns[7].HeaderText = "المخزن";
                base.dgvEntitiesList.Columns[7].Width = 120;

                base.dgvEntitiesList.Columns[8].HeaderText = "حد إعادة الطلب";
                base.dgvEntitiesList.Columns[8].Width = 75;

                base.dgvEntitiesList.Columns[9].HeaderText = "الكمية الحالية";
                base.dgvEntitiesList.Columns[9].Width = 75;

                base.dgvEntitiesList.Columns[10].HeaderText = "متوسط سعر شراء الوحدة (ج.س)";
                base.dgvEntitiesList.Columns[10].Width = 85;
                base.dgvEntitiesList.Columns[10].DefaultCellStyle.Format = "0.##";

                base.dgvEntitiesList.Columns[11].HeaderText = "سعر بيع الوحدة (ج.س)";
                base.dgvEntitiesList.Columns[11].Width = 85;
                base.dgvEntitiesList.Columns[11].DefaultCellStyle.Format = "0.##";

                base.dgvEntitiesList.Columns[12].HeaderText = "تكلفة شراء المخزون (ج.س)";
                base.dgvEntitiesList.Columns[12].Width = 85;
                base.dgvEntitiesList.Columns[12].DefaultCellStyle.Format = "0.##";

                base.dgvEntitiesList.Columns[13].HeaderText = "قيمة بيع المخزون (ج.س)";
                base.dgvEntitiesList.Columns[13].Width = 85;
                base.dgvEntitiesList.Columns[13].DefaultCellStyle.Format = "0.##";

                base.dgvEntitiesList.Columns[14].HeaderText = "الربح المتوقع (ج.س)";
                base.dgvEntitiesList.Columns[14].Width = 85;
                base.dgvEntitiesList.Columns[14].DefaultCellStyle.Format = "0.##";

                base.dgvEntitiesList.Columns[15].HeaderText = "معدل الربح (%)";
                base.dgvEntitiesList.Columns[15].Width = 85;

                base.dgvEntitiesList.Columns[16].HeaderText = "آخر حركة شراء";
                base.dgvEntitiesList.Columns[16].Width = 125;

                base.dgvEntitiesList.Columns[17].HeaderText = "آخر حركة بيع";
                base.dgvEntitiesList.Columns[17].Width = 125;

                base.dgvEntitiesList.Columns[18].HeaderText = "آخر حركة نقل";
                base.dgvEntitiesList.Columns[18].Width = 125;

                base.dgvEntitiesList.Columns[19].HeaderText = "حالة المخزون";
                base.dgvEntitiesList.Columns[19].Width = 85;
            }
        }

    }
}
