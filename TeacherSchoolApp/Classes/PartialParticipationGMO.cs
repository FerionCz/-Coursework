using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSchoolApp.Entities
{
    public partial class ParticipationGMO
    {
        public string FullName => $"{Teacher.Surname} {Teacher.Name} {Teacher.Patronymic}";

        public byte[] ImageAdapter
        {
            get
            {
                if (Image == null)
                {
                    var img = Properties.Resources.no_diploma;
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
