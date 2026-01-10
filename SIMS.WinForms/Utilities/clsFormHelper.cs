using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Parties;
using SIMS.WinForms.Properties;

namespace DVLD.WinForms.Utils
{
    public static class clsFormHelper
    {

        public static bool IsDataGridViewCellsHasError(DataGridView dataGridView, int errorColumnIndex)
        {
            int rowIndex = 0;
            int columnIndex = 0;

            try
            {
                for (rowIndex = 0; rowIndex < dataGridView.Rows.Count - 1; rowIndex++)
                {
                    dataGridView.Rows[rowIndex].ErrorText = string.Empty;

                    for (columnIndex = 0; columnIndex < dataGridView.Rows[rowIndex].Cells.Count; columnIndex++)
                    {
                        if (dataGridView.Columns[columnIndex].Visible)
                        {
                            dataGridView.CurrentCell = dataGridView.Rows[rowIndex].Cells[columnIndex];
                            dataGridView.BeginEdit(true);
                            dataGridView.CancelEdit();

                            if (!string.IsNullOrEmpty(dataGridView.Rows[rowIndex].ErrorText))
                            {
                                string oldError = dataGridView.Rows[rowIndex].ErrorText;
                                dataGridView.CurrentCell = dataGridView.Rows[rowIndex].Cells[errorColumnIndex];
                                dataGridView.BeginEdit(true);
                                dataGridView.Rows[rowIndex].ErrorText = oldError;

                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                dataGridView.Rows[rowIndex].ErrorText = ex.Message;
                return true;
            }

            return false;
        }

        public static void PreventComboBoxAutoSelection(DataGridView dataGridView, ComboBox comboBox)
        {
            if (comboBox != null)
            {
                if (dataGridView.CurrentCell.Value == null || dataGridView.CurrentCell.Value == DBNull.Value)
                {
                    comboBox.SelectedIndex = -1;
                    comboBox.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// Applied a reset of the `e.CellStyle.BackColor` property to the `DataGridView`'s default style. 
        /// This resolves a known issue in Windows Forms where the background of the ComboBox 
        /// cell's drop-down list would** automatically turn black** during editing.
        /// </summary>
        public static void ResetCellBackColor(DataGridView dgv, DataGridViewEditingControlShowingEventArgs e)
        {
            e.CellStyle.BackColor = dgv.DefaultCellStyle.BackColor;
        }

        public static void InitializeDateRangeLimits(
            DateTimePicker dtpDateFrom,
            DateTimePicker dtpDateTo,
            DateTimePicker dtpTimeFrom,
            DateTimePicker dtpTimeTo,
            DateTime firstRecordDate)
        {
            dtpDateFrom.MinDate = dtpDateTo.MinDate = firstRecordDate;
            dtpTimeFrom.MinDate = dtpTimeTo.MinDate = DateTime.MinValue;

            dtpDateFrom.MaxDate = dtpDateTo.MaxDate = DateTime.Now;
            dtpTimeFrom.MaxDate = dtpTimeTo.MaxDate = DateTime.MaxValue;
        }

        public static void InitializeDateRangeLimits(
            DateTimePicker dtpDateFrom,
            DateTimePicker dtpDateTo,
            DateTime firstRecordDate)
        {
            dtpDateFrom.MinDate = dtpDateTo.MinDate = firstRecordDate;
            dtpDateFrom.MaxDate = dtpDateTo.MaxDate = DateTime.Now;
        }

        public static void InitializeAndApplyDateRange(
            DateTimePicker dtpDateFrom,
            DateTimePicker dtpDateTo,
            ComboBox cbRange,
            DateTime firstRecordDate)
        {
            if (firstRecordDate == DateTime.MinValue)
            {
                firstRecordDate = dtpDateFrom.MinDate;
            }

            dtpDateFrom.Enabled = dtpDateTo.Enabled = false;

            dtpDateFrom.MinDate = dtpDateTo.MinDate = firstRecordDate;

            DateTime currentTime = DateTime.Now;

            dtpDateFrom.MaxDate = dtpDateTo.MaxDate = currentTime;

            dtpDateFrom.Value = dtpDateTo.Value = currentTime;

            if (cbRange.SelectedIndex == 0)
            {
                dtpDateFrom.Value = firstRecordDate > DateTime.Now.AddDays(-1) ?
                    firstRecordDate :
                    DateTime.Now.AddDays(-1);
            }
            else if (cbRange.SelectedIndex == 1)
            {
                dtpDateFrom.Value = firstRecordDate > DateTime.Now.AddDays(-7) ?
                    firstRecordDate :
                    DateTime.Now.AddDays(-7);
            }
            else if (cbRange.SelectedIndex == 2)
            {
                dtpDateFrom.Value = firstRecordDate > DateTime.Now.AddMonths(-1) ?
                    firstRecordDate :
                    DateTime.Now.AddMonths(-1);
            }
            else if (cbRange.SelectedIndex == 3)
            {
                dtpDateFrom.Value = firstRecordDate > DateTime.Now.AddMonths(-3) ?
                    firstRecordDate :
                    DateTime.Now.AddMonths(-3);
            }
            else if (cbRange.SelectedIndex == 4)
            {
                dtpDateFrom.Value = firstRecordDate > DateTime.Now.AddMonths(-6) ?
                    firstRecordDate :
                    DateTime.Now.AddMonths(-6);
            }
            else if (cbRange.SelectedIndex == 5)
            {
                dtpDateFrom.Value = firstRecordDate > DateTime.Now.AddYears(-1) ?
                    firstRecordDate :
                    DateTime.Now.AddYears(-1);
            }
            else if (cbRange.SelectedIndex == 6)
            {
                dtpDateFrom.Value = firstRecordDate;
            }
            else
            {
                dtpDateFrom.Enabled = dtpDateTo.Enabled =  true;

                dtpDateFrom.Value = currentTime;
                dtpDateTo.Value = currentTime;
            }
        }

        public static void InitializeAndApplyDateRange(
            DateTimePicker dtpDateFrom,
            DateTimePicker dtpDateTo,
            DateTimePicker dtpTimeFrom,
            DateTimePicker dtpTimeTo,
            ComboBox cbRange,
            DateTime firstRecordDate)
        {
            if (firstRecordDate == DateTime.MinValue)
            {
                firstRecordDate = dtpDateFrom.MinDate;
            }

            dtpDateFrom.Enabled = dtpTimeFrom.Enabled =
                dtpDateTo.Enabled = dtpTimeTo.Enabled = false;

            dtpDateFrom.MinDate = dtpDateTo.MinDate = firstRecordDate;

            DateTime currentTime = DateTime.Now;

            dtpDateFrom.MaxDate = dtpDateTo.MaxDate = currentTime;

            dtpDateFrom.Value = dtpDateTo.Value = dtpTimeFrom.Value =
                dtpTimeTo.Value = currentTime;

            if (cbRange.SelectedIndex == 0)
            {
                dtpDateFrom.Value = dtpTimeFrom.Value = firstRecordDate > DateTime.Now.AddDays(-1) ?
                    firstRecordDate :
                    DateTime.Now.AddDays(-1);
            }
            else if (cbRange.SelectedIndex == 1)
            {
                dtpDateFrom.Value = dtpTimeFrom.Value = firstRecordDate > DateTime.Now.AddDays(-7) ?
                    firstRecordDate :
                    DateTime.Now.AddDays(-7);
            }
            else if (cbRange.SelectedIndex == 2)
            {
                dtpDateFrom.Value = dtpTimeFrom.Value = firstRecordDate > DateTime.Now.AddMonths(-1) ?
                    firstRecordDate :
                    DateTime.Now.AddMonths(-1);
            }
            else if (cbRange.SelectedIndex == 3)
            {
                dtpDateFrom.Value = dtpTimeFrom.Value = firstRecordDate > DateTime.Now.AddMonths(-3) ?
                    firstRecordDate :
                    DateTime.Now.AddMonths(-3);
            }
            else if (cbRange.SelectedIndex == 4)
            {
                dtpDateFrom.Value = dtpTimeFrom.Value = firstRecordDate > DateTime.Now.AddMonths(-6) ?
                    firstRecordDate :
                    DateTime.Now.AddMonths(-6);
            }
            else if (cbRange.SelectedIndex == 5)
            {
                dtpDateFrom.Value = dtpTimeFrom.Value = firstRecordDate > DateTime.Now.AddYears(-1) ?
                    firstRecordDate :
                    DateTime.Now.AddYears(-1);
            }
            else if (cbRange.SelectedIndex == 6)
            {
                dtpDateFrom.Value = firstRecordDate;
                dtpTimeFrom.Value = firstRecordDate;
            }
            else
            {
                dtpDateFrom.Enabled = dtpTimeFrom.Enabled =
                    dtpDateTo.Enabled = dtpTimeTo.Enabled = true;

                dtpDateFrom.Value = currentTime.Date;
                dtpDateTo.Value = currentTime.Date;
                dtpTimeFrom.Value = currentTime.Date;
                dtpTimeTo.Value = currentTime.Date;
            }
        }

        public static void ApplyGreenRedRowStyle<T>(
            DataGridView dgv,
            DataGridViewRowPrePaintEventArgs e,
            string conditionColumnName,
            T greenValue,
            T redValue)
        {
            if (e.RowIndex >= 0)
            {
                T value = (T)(dgv.Rows[e.RowIndex].Cells[conditionColumnName].Value);

                if (value.Equals(greenValue))
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
                }
                else if (value.Equals(redValue))
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = dgv.DefaultCellStyle.BackColor;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dgv.DefaultCellStyle.ForeColor;
                }
            }
        }

        public static void ApplyGreenYellowRedRowStyle<T>(
            DataGridView dgv,
            DataGridViewRowPrePaintEventArgs e,
            string conditionColumnName,
            T greenValue,
            T yellowValue,
            T redValue)
        {
            if (e.RowIndex >= 0)
            {
                T value = (T)(dgv.Rows[e.RowIndex].Cells[conditionColumnName].Value);

                if (value.Equals(greenValue))
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
                }
                else if (value.Equals(redValue))
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else if (value.Equals(yellowValue)) 
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGoldenrod;
                }
                else
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = dgv.DefaultCellStyle.BackColor;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dgv.DefaultCellStyle.ForeColor;
                }
            }
        }

        public static void DisableSortableDataGridViewColumns(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public static int GetSelectedRowID(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int.TryParse(dataGridView.SelectedRows[0].Cells[0].Value.ToString(), out int ID);
                return ID;
            }

            if (dataGridView.CurrentRow.Index >= 0)
            {
                int.TryParse(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString(), out int ID);
                return ID;
            }

            return -1;
        }

        public static int GetSelectedRowID(DataGridView dataGridView, int columnIndex)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int.TryParse(dataGridView.SelectedRows[0].Cells[columnIndex].Value.ToString(), out int ID);
                return ID;
            }

            if (dataGridView.CurrentRow.Index >= 0)
            {
                int.TryParse(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[columnIndex].Value.ToString(), out int ID);
                return ID;
            }

            return -1;
        }

        public static int GetSelectedRowID(DataGridView dataGridView, string columnName)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int.TryParse(dataGridView.SelectedRows[0].Cells[columnName].Value.ToString(), out int ID);
                return ID;
            }

            if (dataGridView.CurrentRow.Index >= 0)
            {
                int.TryParse(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[columnName].Value.ToString(), out int ID);
                return ID;
            }

            return -1;
        }

        public static void SelectingOnCurrentRowByRightMouse(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right && e.RowIndex >= 0 && sender is DataGridView dataGridView)
            {
                dataGridView.Rows[e.RowIndex].Selected = true;
                dataGridView.Columns[e.ColumnIndex].Selected = true;
            }
        }

        public static Point GetCurrentPoint(Control control)
        {
            return control.PointToClient(Cursor.Position);
        }

        public static DataGridView.HitTestInfo GetHitTestInfo(DataGridView dataGridView)
        {
            Point point = GetCurrentPoint(dataGridView);
            return dataGridView.HitTest(point.X, point.Y);
        }

        public static void PreventContextMenuOnEmptyClick(DataGridView dataGridView, System.ComponentModel.CancelEventArgs e)
        {
            DataGridView.HitTestInfo hit = GetHitTestInfo(dataGridView);

            if (hit.Type == DataGridViewHitTestType.None || hit.Type == DataGridViewHitTestType.ColumnHeader)
            {
                dataGridView.ClearSelection();
                e.Cancel = true;
            }
        }

        public static Image GetDefaultPersonImage(clsPerson.enGender gender)
        {
            return gender is clsPerson.enGender.Male ? Resources.unknow_male : Resources.unknow_female;
        }

        public static void ShowPassword(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                if (pictureBox.Tag is TextBox textBox)
                {
                    textBox.UseSystemPasswordChar = false;
                }
            }
        }

        public static void HidePassword(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                if (pictureBox.Tag is TextBox textBox)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
        }

        public static void SetPasswordsVisibility(TextBox[] passwordFields, bool isVisible)
        {
            foreach (TextBox textBox in passwordFields)
            {
                textBox.UseSystemPasswordChar = !isVisible;
            }
        }

    }
}
