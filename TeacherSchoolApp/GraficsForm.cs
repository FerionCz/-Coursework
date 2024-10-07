using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using TeacherSchoolApp.Entities;

namespace TeacherSchoolApp
{
    public partial class GraficsForm : TeacherSchoolApp.FormPattern
    {
        public GraficsForm(List<ParticipationGMO> list)
        {
            InitializeComponent();
            var listByTeachers = list.GroupBy(x => x.Teacher);
            foreach (var item in listByTeachers)
            {
                var series = TeachersChart.Series.Add(item.Key.FullName);
                foreach (var gmo in item)
                {
                    series.Points.AddXY(gmo.Date, item.Count());
                }
            }
        }

        private void GraficsForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
