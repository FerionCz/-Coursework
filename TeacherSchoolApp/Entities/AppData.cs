using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSchoolApp.Entities
{
    public static class AppData
    {
        public static DuplStartEntities Context = new DuplStartEntities();
        public static User AuthUser = new User();
    }
}
