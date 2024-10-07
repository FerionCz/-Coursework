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
using Word = Microsoft.Office.Interop.Word;

namespace TeacherSchoolApp
{
    public partial class StudentAchievementsForm : FormPattern
    {
        public StudentAchievementsForm()
        {
            InitializeComponent();
            DGridAchievements.DataSource = AppData.Context.LearnerAchievements.Where(p => p.TeacherId == AppData.AuthUser.Id).ToList();
            CBoxSort.DataSource = new[] { "Без сортировки", "От А до Я", "От Я до А" };
            CBoxSort.SelectedIndex = 0;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void DGridAchievements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                new AddEditStudentAchievementForm((LearnerAchievement)DGridAchievements.Rows[e.RowIndex].DataBoundItem).Show();
                Close();
            }
            else if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Вы действительно хотите удалить достижение ученика?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AppData.Context.LearnerAchievements.Remove(DGridAchievements.SelectedCells[0].OwningRow.DataBoundItem as LearnerAchievement);
                    AppData.Context.SaveChanges();
                    DGridAchievements.DataSource = AppData.Context.LearnerAchievements.Where(p => p.TeacherId == AppData.AuthUser.Id).ToList();
                }
            }
        }
        private void UpdateList()
        {
            List<LearnerAchievement> achievements = AppData.Context.LearnerAchievements.Where(p => p.TeacherId == AppData.AuthUser.Id).ToList();

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
            DGridAchievements.DataSource = achievements;
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
            new AddEditStudentAchievementForm(null).Show();
            Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            List<LearnerAchievement> achievements = DGridAchievements.DataSource as List<LearnerAchievement>;
            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Add();
            var paragraph = doc.Paragraphs.Add();
            paragraph.Range.set_Style("Заголовок");
            paragraph.Range.Text = "Достижения учеников";
            paragraph.Range.InsertParagraphAfter();
            var tableParagraph = doc.Paragraphs.Add();
            var tableRange = tableParagraph.Range;
            var table = doc.Tables.Add(tableRange, achievements.Count + 1, 6);
            table.Borders.InsideLineStyle = table.Borders.OutsideLineStyle =
                Word.WdLineStyle.wdLineStyleSingle;
            table.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;


            table.Cell(1, 1).Range.Text = "Фото";
            table.Cell(1, 2).Range.Text = "Имя студента";
            table.Cell(1, 3).Range.Text = "Фамилия студента";
            table.Cell(1, 4).Range.Text = "Класс";
            table.Cell(1, 5).Range.Text = "Сфера";
            table.Cell(1, 6).Range.Text = "Дата";

            table.Rows[1].Range.Bold = 1;
            table.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;


            for (int i = 0; i < achievements.Count; i++)
            {
                var currentAchivment = achievements[i];
                File.WriteAllBytes("cashe", currentAchivment.ImageAdapter);
                Word.InlineShape inlineShape = table.Cell(i + 2, 1).Range.InlineShapes.AddPicture(AppContext.BaseDirectory + "\\cashe");
                inlineShape.Width = 60;
                table.Cell(i + 2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                table.Cell(i + 2, 2).Range.Text = currentAchivment.NameStudent;
                table.Cell(i + 2, 3).Range.Text = currentAchivment.SurnameStudent;
                table.Cell(i + 2, 4).Range.Text = currentAchivment.Class;
                table.Cell(i + 2, 5).Range.Text = currentAchivment.AreasOfActivity;
                table.Cell(i + 2, 6).Range.Text = currentAchivment.Date.ToLongDateString();
            }

            app.Visible = true;
        }
    }
}
