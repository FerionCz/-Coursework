using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherSchoolApp.Entities;
using TeacherSchoolApp.Properties;

namespace TeacherSchoolApp
{
    public partial class AddEditStudentAchievementForm : FormPattern
    {
        private LearnerAchievement _achievement;
        private byte[] _photo;
        public AddEditStudentAchievementForm(LearnerAchievement achievement)
        {
            InitializeComponent();
            LabelTeacherSurname.Text = AppData.AuthUser.Teacher.FullName;
            if (achievement != null)
            {
                TBoxName.Text = achievement.NameStudent;
                TBoxSurname.Text = achievement.SurnameStudent;
                TBoxAreasOfActivity.Text = achievement.AreasOfActivity;
                TBoxClass.Text = achievement.Class;
                DatePicker.Value = achievement.Date;
                try
                {
                    MemoryStream ms = new MemoryStream(achievement.Image);
                    Image image = Image.FromStream(ms);
                    pictureBox2.Image = image;
                }
                catch (Exception)
                {
                    pictureBox2.Image = Resources.no_diploma;
                }
            }
            _achievement = achievement;
        }

        private void AddEditStudentAchievementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StudentAchievementsForm f = new StudentAchievementsForm();
            f.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox2.Image = new Bitmap(ofd.FileName);
                    _photo = File.ReadAllBytes(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var errors = "";
            if (string.IsNullOrWhiteSpace(TBoxName.Text)) errors += "Поле Имя не заполнено!\n";
            if (string.IsNullOrWhiteSpace(TBoxSurname.Text)) errors += "Поле Фамилия не заполнено!\n";
            if (string.IsNullOrWhiteSpace(TBoxAreasOfActivity.Text)) errors += "Поле Сфера не заполнено!\n";
            if (string.IsNullOrWhiteSpace(TBoxClass.Text)) errors += "Поле Класс не заполнено!\n";
            if (DatePicker.Value == null) errors += "Дата не выбрана!\n";

            if (errors == "")
            {
                if (_achievement == null)
                {
                    _achievement = new LearnerAchievement()
                    {
                        NameStudent = TBoxName.Text,
                        SurnameStudent = TBoxSurname.Text,
                        AreasOfActivity = TBoxAreasOfActivity.Text,
                        Class = TBoxClass.Text,
                        Date = DatePicker.Value,
                        Image = _photo,
                        Teacher = AppData.AuthUser.Teacher,
                    };
                    AppData.Context.LearnerAchievements.Add(_achievement);
                    AppData.Context.SaveChanges();
                    MessageBox.Show("Достижение успешно добавлено", "ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    _achievement.NameStudent = TBoxName.Text;
                    _achievement.SurnameStudent = TBoxSurname.Text;
                    _achievement.AreasOfActivity = TBoxAreasOfActivity.Text;
                    _achievement.Class = TBoxClass.Text;
                    _achievement.Image = _photo;
                    _achievement.Date = DatePicker.Value;
                    _achievement.Teacher = _achievement.Teacher;
                    AppData.Context.SaveChanges();
                    MessageBox.Show("Достижение успешно отредактировано", "ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                MessageBox.Show(errors, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
