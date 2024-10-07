using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSchoolApp.Entities
{
    public partial class LearnerAchievement
    {
        public string TeacherFullName => $"{Teacher.Surname} {Teacher.Name} {Teacher.Patronymic}";

    }
}
