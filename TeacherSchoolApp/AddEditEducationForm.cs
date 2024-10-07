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
    public partial class AddEditEducationForm : FormPattern
    {
        private Education _education;
        public AddEditEducationForm(Education education)
        {
            InitializeComponent();
            _education = education;
            CBoxTeacher.DataSource = AppData.Context.Teachers.ToList();
            CBoxTeacher.DisplayMember = "FullName";
            if (education != null)
            {
                TBoxName.Text = education.InstituteName;
                TBoxSpec.Text = education.DiplomaSpecialty;
                CBoxTeacher.SelectedItem = education.Teacher;
                CBoxTeacher.Text = education.Teacher.FullName;
                dateTimePicker2.Value = education.DateEnd;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var errors = "";
            if (string.IsNullOrWhiteSpace(TBoxName.Text)) errors += "Поле Название не заполнено!\n";
            if (string.IsNullOrWhiteSpace(TBoxSpec.Text)) errors += "Поле Специализация не заполнено!\n";
            if (string.IsNullOrWhiteSpace(CBoxTeacher.Text)) errors += "Поле Преподаватель не заполнено!\n";
            if (dateTimePicker2.Value == null) errors += "Дата окончания не выбрана!\n";

            if (errors == "")
            {
                if (_education == null)
                {
                    _education = new Education()
                    {
                        InstituteName = TBoxName.Text,
                        DiplomaSpecialty = TBoxSpec.Text,
                        TeacherId = (CBoxTeacher.SelectedItem as Teacher).Id,
                        DateEnd = dateTimePicker2.Value,
                    };
                    AppData.Context.Educations.Add(_education);
                    AppData.Context.SaveChanges();
                    MessageBox.Show("Образование успешно добавлено", "ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    _education.InstituteName = TBoxName.Text;
                    _education.DiplomaSpecialty = TBoxSpec.Text;
                    _education.TeacherId = (CBoxTeacher.SelectedItem as Teacher).Id;
                    _education.DateEnd = dateTimePicker2.Value;
                    AppData.Context.SaveChanges();
                    MessageBox.Show("Образование успешно отредактировано", "ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                MessageBox.Show(errors, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEditEducationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TeachersForm f = new TeachersForm();
            f.Show();
        }
    }
}
