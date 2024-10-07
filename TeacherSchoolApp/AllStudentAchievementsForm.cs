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
    public partial class AllStudentAchievementsForm : FormPattern
    {
        public AllStudentAchievementsForm()
        {
            InitializeComponent();
            dataGridViewLearnerAchievements.DataSource = AppData.Context.LearnerAchievements.ToList();
            CBoxSort.DataSource = new[] { "Без сортировки", "От А до Я", "От Я до А" };
            CBoxSort.SelectedIndex = 0;
        }

        private void AllStudentAchievementsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duplStartDataSet.LearnerAchievements' table. You can move, or remove it, as needed.
            //this.learnerAchievementsTableAdapter.Fill(this.duplStartDataSet.LearnerAchievements);

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void dataGridViewLearnerAchievements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                new AddEditAllStudentAchievementsForm((LearnerAchievement)dataGridViewLearnerAchievements.Rows[e.RowIndex].DataBoundItem).Show();
                Close();
            }
            else if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Вы действительно хотите удалить достижение ученика?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AppData.Context.LearnerAchievements.Remove(dataGridViewLearnerAchievements.SelectedCells[0].OwningRow.DataBoundItem as LearnerAchievement);
                    AppData.Context.SaveChanges();
                    dataGridViewLearnerAchievements.DataSource = AppData.Context.LearnerAchievements.ToList();
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new AddEditAllStudentAchievementsForm(null).Show();
            Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            new ReportFormAllAchievementStudent(dataGridViewLearnerAchievements.DataSource as List<LearnerAchievement>).Show();
            Close();
        }

        private void TBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
        }
        private void UpdateList()
        {
            List<LearnerAchievement> achievements = AppData.Context.LearnerAchievements.ToList();

            if (!string.IsNullOrWhiteSpace(TBoxSearch.Text))
                achievements = achievements.Where(x => x.NameStudent.ToLower().Contains(TBoxSearch.Text.ToLower()) ||
                x.SurnameStudent.ToLower().Contains(TBoxSearch.Text.ToLower()) ||
                x.Class.ToLower().Contains(TBoxSearch.Text.ToLower()) ||
                x.Teacher.FullName.ToLower().Contains(TBoxSearch.Text.ToLower()) ||
                x.AreasOfActivity.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();

            switch (CBoxSort.SelectedIndex)
            {
                case 1:
                    achievements = achievements.OrderBy(x => x.SurnameStudent).ToList();
                    break;
                case 2:
                    achievements = achievements.OrderByDescending(x => x.SurnameStudent).ToList();
                    break;
                default:
                    break;
            }
            dataGridViewLearnerAchievements.DataSource = achievements;
        }
        private void CBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}
