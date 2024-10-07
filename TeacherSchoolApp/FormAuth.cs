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
    public partial class FormAuth : FormPattern
    {
        public FormAuth()
        {
            InitializeComponent();
            PBoxPassword.PasswordChar = '*';
        }

        private void BtnAuth_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBoxLogin.Text) && !string.IsNullOrWhiteSpace(PBoxPassword.Text))
            {
                if (AppData.Context.Users.ToList().FirstOrDefault(x => x.Login == TBoxLogin.Text && PBoxPassword.Text == x.Password) is User user)
                {
                    AppData.AuthUser = user;
                    Hide();
                    MenuForm f = new MenuForm();
                    f.Show();

                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните оба поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TBoxLogin.Text = "";
            PBoxPassword.Text = "";
        }
    }
}
