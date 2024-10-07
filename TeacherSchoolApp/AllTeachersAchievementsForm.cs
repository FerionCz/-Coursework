using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherSchoolApp.Entities;

namespace TeacherSchoolApp
{
    public partial class AllTeachersAchievementsForm : FormPattern
    {
        public AllTeachersAchievementsForm()
        {
            InitializeComponent();
            dataGridViewTeachersAchievements.DataSource = AppData.Context.ParticipationGMOes.ToList();
            CBoxSort.DataSource = new string[] { "Без сортировки", "По названию (возр.)", "По названию (убыв.)", "По дате (возр.)", "По дате (убыв.)" };
            CBoxSort.SelectedIndex = 0;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new AddEditAllTeacherAchievementsForm(null).Show();
            Close();
        }

        private void BtnStat_Click(object sender, EventArgs e)
        {
            var list = dataGridViewTeachersAchievements.DataSource as List<ParticipationGMO>;
            new GraficsForm(list).ShowDialog();
        }

        private void TBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void DPickerFilter_ValueChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void CBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void dataGridViewTeachersAchievements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                new AddEditAllTeacherAchievementsForm((ParticipationGMO)dataGridViewTeachersAchievements.Rows[e.RowIndex].DataBoundItem).Show();
                Close();
            }
            else if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Вы действительно хотите удалить достижение?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AppData.Context.ParticipationGMOes.Remove(dataGridViewTeachersAchievements.SelectedCells[0].OwningRow.DataBoundItem as ParticipationGMO);
                    AppData.Context.SaveChanges();
                    dataGridViewTeachersAchievements.DataSource = AppData.Context.ParticipationGMOes.ToList();
                }
            }
        }
        private void UpdateList()
        {
            List<ParticipationGMO> parts = AppData.Context.ParticipationGMOes.ToList();
            string text = TBoxSearch.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(text))
                parts = parts.Where(x => x.Event.ToLower().Contains(text) || x.Date.ToString().Contains(text)).ToList();

            if(ChBoxHasDate.Checked)
                parts = parts.Where(x => x.Date.Date == DatePicker.Value.Date).ToList();


            switch (CBoxSort.SelectedIndex)
            {
                case 1:
                    parts = parts.OrderBy(x => x.Event).ToList();
                    break;
                case 2:
                    parts = parts.OrderByDescending(x => x.Event).ToList();
                    break;
                case 3:
                    parts = parts.OrderBy(x => x.Date).ToList();
                    break;
                case 4:
                    parts = parts.OrderByDescending(x => x.Date).ToList();
                    break;
                default:
                    break;
            }




            dataGridViewTeachersAchievements.DataSource = parts;
        }

        private void ChBoxHasDate_CheckedChanged(object sender, EventArgs e)
        {

            DatePicker.Enabled = ChBoxHasDate.Checked;
            label3.Enabled = ChBoxHasDate.Checked;
            UpdateList();
        }
    }
}
