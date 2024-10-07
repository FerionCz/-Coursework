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

namespace TeacherSchoolApp
{
    public partial class ReportFormAllAchievementStudent : FormPattern
    {
        public ReportFormAllAchievementStudent(List<LearnerAchievement> achievements)
        {
            InitializeComponent();
            string rep =
           @"
                <html>
                <head>
                <meta charset='utf-8'>
                <title>МБОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов №3</title>
                <style>
                .title{
                text-align: center;
                font-weight: bold;

                table{
                width: 100%;
                border-collapse: collapse;
                }
                td{
                text-align: center;
                border: solid black 1px;
                }
                .headersRow{
                font-weight: bold;
                }
                </style>
                </head>
                <body>
                <p class='title'>МБОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов №3</p>
                <table id='table1'>
                <tr class='headersRow'>
                <td>Имя студента</td>
                <td>Фамилия студента</td>
                <td>Класс</td>
                <td>Сфера</td>
                <td>Дата</td>
                <td>Фамилия учителя</td>
                <td>Имя учителя</td>
                <td>Отчество учителя</td>

                </tr>";
            foreach (var item in achievements)
            {
                rep +=
                    @"
                    <tr class='dataRow'>
                    <td>" + item.NameStudent + @" </td>
                    <td>" + item.SurnameStudent + @"</td>
                    <td>" + item.Class + @"</td>
                    <td>" + item.AreasOfActivity + @"</td>
                    <td>" + item.Date + @"</td>
                    <td>" + item.Teacher.Surname + @"</td>
                    <td>" + item.Teacher.Name + @"</td>
                    <td>" + item.Teacher.Patronymic + @"</td>
                    </tr>";
            }

            rep +=
                @"
                    </table>
                    </bode>
                    </html>";
            string filename = Application.StartupPath + @"\report.html";
            using (FileStream fs = new FileStream("report.html", FileMode.Create))
            {

                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(rep);
                }

            }
            webBrowser1.Navigate(filename);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
            AllStudentAchievementsForm f = new AllStudentAchievementsForm();
            f.Show();
        }

        private void BtnHTML_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Файлы HTML|*.html";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(dialog.FileName, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(webBrowser1.DocumentText);
                        Close();
                        AllStudentAchievementsForm f = new AllStudentAchievementsForm();
                        f.Show();
                    }
                }
            }
        }
    }
}
