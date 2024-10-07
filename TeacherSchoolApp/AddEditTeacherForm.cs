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
    public partial class AddEditTeacherForm : FormPattern
    {
        private Teacher _teacher;
        private byte[] _photo;
        private byte[] _photo1;
        private byte[] _photo2;
        public AddEditTeacherForm(Teacher teacher)
        {
            InitializeComponent();
            if (teacher != null)
            {
                TBoxName.Text = teacher.Name;
                TBoxSurname.Text = teacher.Surname;
                TBoxPatronymic.Text = teacher.Patronymic;
                TBoxAddress.Text = teacher.Adress;
                TBoxPhone.Text = teacher.Phone;
                TBoxPassport.Text = teacher.Passport;
                DatePicker.Value = teacher.DateOfBirth;
                TBoxEmail.Text = teacher.Email;
                try
                {
                    MemoryStream ms = new MemoryStream(teacher.Image);
                    Image image = Image.FromStream(ms);
                    ImgUser.Image = image;
                    _photo = ms.ToArray();
                }

                catch (Exception)
                {
                    ImgUser.Image = Resources.no_profile_img;

                }
                try
                {
                    MemoryStream ms2 = new MemoryStream(teacher.Court_Certificate);
                    Image image2 = Image.FromStream(ms2);
                    pictureBox2.Image = image2;
                    _photo1 = ms2.ToArray();
                }
                catch (Exception)
                {
                    pictureBox2.Image = Resources.no_profile_img;

                }
                try
                {

                    MemoryStream ms3 = new MemoryStream(teacher.Drugs_Certificate);
                    Image image3 = Image.FromStream(ms3);
                    pictureBox3.Image = image3;
                    _photo2 = ms3.ToArray();
                }
                catch (Exception)
                {
                    pictureBox3.Image = Resources.no_profile_img;

                }
            }
            _teacher = teacher;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var errors = "";
            if (string.IsNullOrWhiteSpace(TBoxLogin.Text)) errors += "Поле Логин не заполнено!\n";
            if (string.IsNullOrWhiteSpace(TBoxPassword.Text)) errors += "Поле Пароль не заполнено!\n";
            if (string.IsNullOrWhiteSpace(TBoxSurname.Text)) errors += "Поле Фамилия не заполнено!\n";
            if (string.IsNullOrWhiteSpace(TBoxName.Text)) errors += "Поле Имя не заполнено!\n";
            if (string.IsNullOrWhiteSpace(TBoxPatronymic.Text)) errors += "Поле Отчество не заполнено!\n";
            if (string.IsNullOrWhiteSpace(TBoxPassport.Text)) errors += "Поле Паспорт не заполнено!\n";
            if (string.IsNullOrWhiteSpace(TBoxEmail.Text)) errors += "Поле Email не заполнено!\n";
            if (string.IsNullOrWhiteSpace(TBoxAddress.Text)) errors += "Поле Адрес не заполнено!\n";
            if (string.IsNullOrWhiteSpace(TBoxPhone.Text)) errors += "Поле Телефон не заполнено!\n";
            if (DatePicker.Value == null) errors += "Поле Дата рождения не заполнено!!\n";
            if (pictureBox2.Image == null)
            {
                errors += "Сертификат об отсутствии наркологической зависимости не загружен!\n";
            }
            if (pictureBox3.Image == null)
            {
                errors += "Сертификат об отсутствии судимости не загружен!\n";
            }

            if (errors == "")
            {
                if (_teacher == null)
                {
                    User user = new User()
                    {
                        Login = TBoxLogin.Text,
                        Password = TBoxPassword.Text,
                        RoleId = 2,

                    };
                    AppData.Context.Users.Add(user);
                    AppData.Context.SaveChanges();
                    int LastIdUser = Convert.ToInt32(AppData.Context.Users.Max(p => p.Id));
                    _teacher = new Teacher()
                    {
                        Id = LastIdUser,
                        Surname = TBoxSurname.Text,
                        Name = TBoxName.Text,
                        Patronymic = TBoxPatronymic.Text,
                        Passport = TBoxPassport.Text,
                        Phone = TBoxPhone.Text,
                        DateOfBirth = DatePicker.Value,
                        Adress = TBoxAddress.Text,
                        Email = TBoxEmail.Text,
                        Image = _photo,
                        Court_Certificate = _photo1,
                        Drugs_Certificate = _photo2,
                    };
                    AppData.Context.Teachers.Add(_teacher);
                    AppData.Context.SaveChanges();
                    MessageBox.Show("Пользователь успешно создан", "ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    _teacher.User.Login = TBoxLogin.Text;
                    _teacher.User.Password = TBoxPassword.Text;
                    _teacher.Surname = TBoxSurname.Text;
                    _teacher.Name = TBoxName.Text;
                    _teacher.DateOfBirth = DatePicker.Value;
                    _teacher.Patronymic = TBoxPatronymic.Text;
                    _teacher.Passport = TBoxPassport.Text;
                    _teacher.Phone = TBoxPhone.Text;
                    _teacher.Adress = TBoxAddress.Text;
                    _teacher.Email = TBoxEmail.Text;
                    _teacher.Image = _photo;
                    _teacher.Court_Certificate = _photo1;
                    _teacher.Drugs_Certificate = _photo2;
                    AppData.Context.SaveChanges();
                    MessageBox.Show("Пользователь успешно отредактирован", "ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                MessageBox.Show(errors, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void AddEditTeacherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TeachersForm f = new TeachersForm();
            f.Show();
        }

        private void BtnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImgUser.Image = new Bitmap(ofd.FileName);
                    _photo = File.ReadAllBytes(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {   
                try
                {
                    pictureBox2.Image = new Bitmap(ofd.FileName);
                    _photo1 = File.ReadAllBytes(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox3.Image = new Bitmap(ofd.FileName);
                    _photo2 = File.ReadAllBytes(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
