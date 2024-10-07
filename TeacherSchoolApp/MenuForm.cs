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
    public partial class MenuForm : FormPattern
    {
        public MenuForm()
        {
            InitializeComponent();
            labelHello.Text = $"Добро пожаловать, {AppData.AuthUser.Teacher.FullName}";
            if (AppData.AuthUser.RoleId != 1)
            {
                BtnTeachers.Visible = false;
                BtnAllAchievementsStudent.Visible = false;
                BtnAllAchievementsTeacher.Visible = false;
            }
        }

        private void BtnAchievementsStudent_Click(object sender, EventArgs e)
        {
            Close();
            StudentAchievementsForm f = new StudentAchievementsForm();
            f.Show();
        }

        private void BtnMyAchievements_Click(object sender, EventArgs e)
        {
            Close();
            MyAchievementsForm f = new MyAchievementsForm(AppData.AuthUser.Teacher);
            f.Show();
        }

        private void BtnMyProfile_Click(object sender, EventArgs e)
        {
            Close();
            MyProfileForm f = new MyProfileForm(AppData.AuthUser.Teacher);
            f.Show();
        }

        private void BtnTeachers_Click(object sender, EventArgs e)
        {
            Close();
            TeachersForm f = new TeachersForm();
            f.Show();
        }

        private void BtnAllAchievementsStudent_Click(object sender, EventArgs e)
        {
            Close();
            AllStudentAchievementsForm f = new AllStudentAchievementsForm();
            f.Show();
        }

        private void BtnAllAchievementsTeacher_Click(object sender, EventArgs e)
        {
            Close();
            AllTeachersAchievementsForm f = new AllTeachersAchievementsForm();
            f.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
            FormAuth f = new FormAuth();
            f.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
