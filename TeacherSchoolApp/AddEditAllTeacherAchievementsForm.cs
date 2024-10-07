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
    public partial class AddEditAllTeacherAchievementsForm : FormPattern
    {
        private ParticipationGMO _part;
        private byte[] _photo;
        public AddEditAllTeacherAchievementsForm(ParticipationGMO part)
        {
            InitializeComponent();
            CBoxTeacher.DataSource = AppData.Context.Teachers.ToList();
            CBoxTeacher.DisplayMember = "FullName";
            if (part != null)
            {
                TBoxEvent.Text = part.Event;
                DatePicker.Value = part.Date;
                try
                {
                    MemoryStream ms = new MemoryStream(part.Image);
                    Image image = Image.FromStream(ms);
                    ImgDiploma.Image = image;
                }
                catch (Exception)
                {
                    ImgDiploma.Image = Resources.no_diploma;
                }
                CBoxTeacher.SelectedItem = part.Teacher;
            }
            _part = part;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var errors = "";
            if (string.IsNullOrWhiteSpace(TBoxEvent.Text)) errors += "Поле Мероприятие не заполнено!\n";
            if (string.IsNullOrWhiteSpace(CBoxTeacher.Text)) errors += "Преподаватель не выбран!\n";
            if (DatePicker.Value == null) errors += "Дата не выбрана!\n";

            if (errors == "")
            {
                if (_part == null)
                {
                    _part = new ParticipationGMO()
                    {
                        Event = TBoxEvent.Text,
                        Date = DatePicker.Value,
                        Image = _photo,
                        Teacher = CBoxTeacher.SelectedItem as Teacher,
                    };
                    AppData.Context.ParticipationGMOes.Add(_part);
                    AppData.Context.SaveChanges();
                    MessageBox.Show("Достижение успешно добавлено", "ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    _part.Event = TBoxEvent.Text;
                    _part.Image = _photo;
                    _part.Date = DatePicker.Value;
                    _part.Teacher = CBoxTeacher.SelectedItem as Teacher;
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

        private void BtnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImgDiploma.Image = new Bitmap(ofd.FileName);
                    _photo = File.ReadAllBytes(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEditAllTeacherAchievementsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AllTeachersAchievementsForm f = new AllTeachersAchievementsForm();
            f.Show();
        }
    }
}
