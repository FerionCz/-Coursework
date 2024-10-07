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
    public partial class AddEditProfDevelopmentForm : FormPattern
    {
        private ProfessionalDevelopment _development;
        public AddEditProfDevelopmentForm(ProfessionalDevelopment development)
        {
            InitializeComponent();
            _development = development;
            CBoxTeacher.DataSource = AppData.Context.Teachers.ToList();
            CBoxTeacher.DisplayMember = "FullName";
            if (development != null)
            {
                TBoxName.Text = development.Name;
                TBoxLocation.Text = development.LocationCoursework;
                CBoxTeacher.SelectedItem = development.Teacher;
                CBoxTeacher.Text = development.Teacher.FullName;
                dateTimePicker1.Value = development.StartDate;
                dateTimePicker2.Value = development.EndDate;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var errors = "";
            if (string.IsNullOrWhiteSpace(TBoxName.Text)) errors += "Поле Название не заполнено!\n";
            if (string.IsNullOrWhiteSpace(TBoxLocation.Text)) errors += "Поле Место проведения не заполнено!\n";
            if (string.IsNullOrWhiteSpace(CBoxTeacher.Text)) errors += "Поле Преподаватель не заполнено!\n";
            if (dateTimePicker1.Value == null) errors += "Дата начала не выбрана!\n";
            if (dateTimePicker2.Value == null) errors += "Дата окончания не выбрана!\n";

            if (errors == "")
            {
                if (_development == null)
                {
                    _development = new ProfessionalDevelopment()
                    {
                        Name = TBoxName.Text,
                        LocationCoursework = TBoxLocation.Text,
                        TeacherId = (CBoxTeacher.SelectedItem as Teacher).Id,
                        StartDate = dateTimePicker1.Value,
                        EndDate = dateTimePicker2.Value,
                    };
                    AppData.Context.ProfessionalDevelopments.Add(_development);
                    AppData.Context.SaveChanges();
                    MessageBox.Show("Проф.развитие успешно добавлено", "ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    _development.Name = TBoxName.Text;
                    _development.LocationCoursework = TBoxLocation.Text;
                    _development.TeacherId = (CBoxTeacher.SelectedItem as Teacher).Id;
                    _development.StartDate = dateTimePicker1.Value;
                    _development.EndDate = dateTimePicker2.Value;
                    AppData.Context.SaveChanges();
                    MessageBox.Show("Проф.развитие успешно отредактировано", "ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                MessageBox.Show(errors, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEditProfDevelopmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TeachersForm f = new TeachersForm();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
