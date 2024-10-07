using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherSchoolApp.Classes;
using TeacherSchoolApp.Entities;

namespace TeacherSchoolApp
{
    public partial class TeachersForm : FormPattern
    {
        public TeachersForm()
        {
            InitializeComponent();
            DGridTeachers.DataSource = AppData.Context.Teachers.ToList();
            CBoxSort.DataSource = new[] { "Без сортировки", "От А до Я", "От Я до А" };
            CBoxSort.SelectedIndex = 0;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void UpdateList()
        {
            List<Teacher> teachers = AppData.Context.Teachers.ToList();



            if (!string.IsNullOrWhiteSpace(TBoxSearch.Text))
                teachers = teachers.Where(x => x.FullName.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();

            switch (CBoxSort.SelectedIndex)
            {
                case 1:
                    teachers = teachers.OrderBy(x => x.Surname).ThenBy(x => x.Name).ThenBy(x => x.Patronymic).ToList();
                    break;
                case 2:
                    teachers = teachers.OrderByDescending(x => x.Surname).ThenByDescending(x => x.Name).ThenByDescending(x => x.Patronymic).ToList();
                    break;

                default:
                    break;
            }
            DGridTeachers.DataSource = teachers;
        }
        private void DGridTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                new AddEditTeacherForm((Teacher)DGridTeachers.Rows[e.RowIndex].DataBoundItem).Show();
                Close();
            }
            else if (e.ColumnIndex == 12)
            {
                if (MessageBox.Show("Вы действительно хотите удалить преподавателя?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AppData.Context.Teachers.Remove(DGridTeachers.SelectedCells[0].OwningRow.DataBoundItem as Teacher);
                    AppData.Context.SaveChanges();
                    DGridTeachers.DataSource = AppData.Context.Teachers.ToList();
                }
            }
            else if (e.ColumnIndex == 10)
            {
                new ProfessionalDevelopmentForm((Teacher)DGridTeachers.Rows[e.RowIndex].DataBoundItem).Show();
                Close();
            }
            else if (e.ColumnIndex == 9)
            {
                new EducationForm((Teacher)DGridTeachers.Rows[e.RowIndex].DataBoundItem).Show();
                Close();
            }
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            var data = DGridTeachers.DataSource as List<Teacher>;
            using (ExcelWriter writer = new ExcelWriter())
            {
                writer.Sheet.Name = $"Отчет на {DateTime.Now.ToShortDateString()}";
                writer.CreateHeaders(new[] {"Фамилия", "Имя", "Отчество", "Телефон",
                "Адрес", "Паспорт", "Дата рождения", "Email"},
                Microsoft.Office.Interop.Excel.XlRgbColor.rgbGreen, Microsoft.Office.Interop.Excel.XlRgbColor.rgbWhite);
                foreach (var item in data)
                {
                    writer.CreateRow(new[] {item.Surname, item.Name, item.Patronymic, item.Phone,
                    item.Adress,item.Passport, item.DateOfBirth.ToLongDateString(),item.Email});
                }
                
            }
        }

        private void CBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void TBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new AddEditTeacherForm(null).Show();
            Close();
        }
    }
}
