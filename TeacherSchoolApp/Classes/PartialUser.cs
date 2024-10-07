using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSchoolApp.Entities
{
    public partial class Teacher
    {
        public string FullName => $"{Surname} {Name} {Patronymic}";
        public byte[] ImageAdapter
        {
            get
            {
                if (Image == null)
                {
                    var img = Properties.Resources.no_profile_img;
                    using (var stream = new MemoryStream())
                    {
                        img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        return stream.ToArray();
                    }
                }
                return Image;
            }
        }
    }
}
