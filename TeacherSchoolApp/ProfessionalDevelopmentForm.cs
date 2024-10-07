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
    public partial class ProfessionalDevelopmentForm : FormPattern
    {
        private Teacher _teacher;
        public ProfessionalDevelopmentForm(Teacher teacher)
        {
            InitializeComponent();
            _teacher = teacher;
            DGridProfessionalDevelopment.DataSource = AppData.Context.ProfessionalDevelopments.Where(p => p.TeacherId == teacher.Id).ToList();
            CBoxSort.DataSource = new[] { "Без сортировки", "От А до Я", "От Я до А" };
            CBoxSort.SelectedIndex = 0;
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {

            Close();
            TeachersForm f = new TeachersForm();
            f.Show();
        }
        private void UpdateList()
        {
            List<ProfessionalDevelopment> profs = AppData.Context.ProfessionalDevelopments.Where(p => p.TeacherId == _teacher.Id).ToList();

            if (!string.IsNullOrWhiteSpace(TBoxSearch.Text))
                profs = profs.Where(x => x.Name.ToLower().Contains(TBoxSearch.Text.ToLower()) || x.LocationCoursework.ToLower().Contains(TBoxSearch.Text.ToLower()) || x.StartDate.ToString().Contains(TBoxSearch.Text.ToLower()) || x.EndDate.ToString().Contains(TBoxSearch.Text.ToLower())).ToList();

            switch (CBoxSort.SelectedIndex)
            {
                case 1:
                    profs = profs.OrderBy(x => x.Name).ToList();
                    break;
                case 2:
                    profs = profs.OrderByDescending(x => x.Name).ToList();
                    break;

                default:
                    break;
            }
            DGridProfessionalDevelopment.DataSource = profs;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {

        }

        private void TBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void CBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void DGridProfessionalDevelopment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                new AddEditProfDevelopmentForm((ProfessionalDevelopment)DGridProfessionalDevelopment.Rows[e.RowIndex].DataBoundItem).Show();
                Close();
            }
            else if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Вы действительно хотите удалить проф.развитие?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AppData.Context.ProfessionalDevelopments.Remove(DGridProfessionalDevelopment.SelectedCells[0].OwningRow.DataBoundItem as ProfessionalDevelopment);
                    AppData.Context.SaveChanges();
                    DGridProfessionalDevelopment.DataSource = AppData.Context.ProfessionalDevelopments.Where(p => p.TeacherId == _teacher.Id).ToList();
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            new AddEditProfDevelopmentForm(null).Show();
            Close();
        }
    }
}
