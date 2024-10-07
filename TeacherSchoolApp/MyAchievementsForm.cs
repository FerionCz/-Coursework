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
    public partial class MyAchievementsForm : FormPattern
    {
        private Teacher _teacher;
        public MyAchievementsForm(Teacher teacher)
        {
            InitializeComponent();
            DGridAchievements.DataSource = teacher.ParticipationGMOes.ToList();
            _teacher = teacher;
            CBoxSort.DataSource = new string[] { "Без сортировки", "По названию (возр.)", "По названию (убыв.)", "По дате (возр.)", "По дате (убыв.)" };
            CBoxSort.SelectedIndex = 0;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new AddEditMyAchievementForm(null).Show();
            Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            List<ParticipationGMO> achievements = DGridAchievements.DataSource as List<ParticipationGMO>;
            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Add();
            var paragraph = doc.Paragraphs.Add();
            paragraph.Range.set_Style("Заголовок");
            paragraph.Range.Text = "Личные достижения";
            paragraph.Range.InsertParagraphAfter();
            var tableParagraph = doc.Paragraphs.Add();
            var tableRange = tableParagraph.Range;
            var table = doc.Tables.Add(tableRange, achievements.Count + 1, 4);
            table.Borders.InsideLineStyle = table.Borders.OutsideLineStyle =
                Word.WdLineStyle.wdLineStyleSingle;
            table.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;


            table.Cell(1, 1).Range.Text = "Фото";
            table.Cell(1, 2).Range.Text = "Мероприятие";
            table.Cell(1, 3).Range.Text = "Дата";
            table.Cell(1, 4).Range.Text = "Преподаватель";

            table.Rows[1].Range.Bold = 1;
            table.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;


            for (int i = 0; i < achievements.Count; i++)
            {
                var currentAchivment = achievements[i];
                File.WriteAllBytes("cashe", currentAchivment.ImageAdapter);
                Word.InlineShape inlineShape = table.Cell(i + 2, 1).Range.InlineShapes.AddPicture(AppContext.BaseDirectory + "\\cashe");
                inlineShape.Width = 60;
                table.Cell(i + 2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                table.Cell(i + 2, 2).Range.Text = currentAchivment.Event;
                table.Cell(i + 2, 3).Range.Text = currentAchivment.Teacher.FullName;
                table.Cell(i + 2, 4).Range.Text = currentAchivment.Date.ToLongDateString();
            }

            app.Visible = true;
        }

        private void TBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void CBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void DPickerFilter_ValueChanged(object sender, EventArgs e)
        {
            UpdateList();
        }
        private void UpdateList()
        {
            List<ParticipationGMO> parts = _teacher.ParticipationGMOes.ToList();
            string text = TBoxSearch.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(text))
                parts = parts.Where(x => x.Event.ToLower().Contains(text) || x.Date.ToString().Contains(text)).ToList();

            switch (CBoxSort.SelectedIndex)
            {
                case 0:
                    parts = parts;
                    break;
                case 1:
                    parts = parts.OrderBy(x => x.Event).ToList();
                    break;
                case 2:
                    parts = parts.OrderByDescending(x => x.Event).ToList();
                    break;
                case 3:
                    parts = parts.OrderBy(x => x.Date).ToList();
                    break;
                case 4:
                    parts = parts.OrderByDescending(x => x.Date).ToList();
                    break;
                default:
                    break;
            }

            if (ChBoxHasDate.Checked)
            {
                parts = parts.Where(x => x.Date.Date == DatePicker.Value.Date).ToList();
            }



            DGridAchievements.DataSource = parts;
        }

        private void DGridAchievements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==3 )
            {
                new AddEditMyAchievementForm((ParticipationGMO)DGridAchievements.Rows[e.RowIndex].DataBoundItem).Show();
                Close();
            }
            else if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Вы действительно хотите удалить достижение?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AppData.Context.ParticipationGMOes.Remove(DGridAchievements.SelectedCells[0].OwningRow.DataBoundItem as ParticipationGMO);
                    AppData.Context.SaveChanges();
                    DGridAchievements.DataSource = _teacher.ParticipationGMOes.ToList();
                }
            }
        }

        private void ChBoxHasDate_CheckedChanged(object sender, EventArgs e)
        {

            DatePicker.Enabled = ChBoxHasDate.Checked;
            label3.Enabled = ChBoxHasDate.Checked;
            UpdateList();

        }
    }
}
