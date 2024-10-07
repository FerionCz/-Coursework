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
    public partial class EducationForm : FormPattern
    {
        private Teacher _teacher;
        public EducationForm(Teacher teacher)
        {
            InitializeComponent();
            _teacher = teacher;
            DGridEducation.DataSource = AppData.Context.Educations.Where(i=>i.TeacherId == teacher.Id).ToList();
            CBoxSort.DataSource = new[] { "Без сортировки", "От А до Я", "От Я до А" };
            CBoxSort.SelectedIndex = 0;
        }

        private void EducationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "duplStartDataSet9.Education". При необходимости она может быть перемещена или удалена.
            this.educationTableAdapter.Fill(this.duplStartDataSet9.Education);

        }
        private void UpdateList()
        {
            List<Education> educations = AppData.Context.Educations.Where(p => p.TeacherId == _teacher.Id).ToList();

            if (!string.IsNullOrWhiteSpace(TBoxSearch.Text))
                educations = educations.Where(x => x.InstituteName.ToLower().Contains(TBoxSearch.Text.ToLower()) || x.Teacher.FullName.ToLower().Contains(TBoxSearch.Text.ToLower()) || x.DiplomaSpecialty.ToString().Contains(TBoxSearch.Text.ToLower()) || x.DateEnd.ToString().Contains(TBoxSearch.Text.ToLower())).ToList();

            switch (CBoxSort.SelectedIndex)
            {
                case 1:
                    educations = educations.OrderBy(x => x.InstituteName).ToList();
                    break;
                case 2:
                    educations = educations.OrderByDescending(x => x.InstituteName).ToList();
                    break;

                default:
                    break;
            }
            DGridEducation.DataSource = educations;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new AddEditEducationForm(null).Show();
            Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

            Close();
            TeachersForm f = new TeachersForm();
            f.Show();
        }

        private void TBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void CBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void DGridEducation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                new AddEditEducationForm((Education)DGridEducation.Rows[e.RowIndex].DataBoundItem).Show();
                Close();
            }
            else if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Вы действительно хотите удалить образование?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AppData.Context.Educations.Remove(DGridEducation.SelectedCells[0].OwningRow.DataBoundItem as Education);
                    AppData.Context.SaveChanges();
                    DGridEducation.DataSource = AppData.Context.Educations.Where(p => p.TeacherId == _teacher.Id).ToList();
                }
            }
        }
    }
}
