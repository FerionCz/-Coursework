//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeacherSchoolApp.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProfessionalDevelopment
    {
        public int ID { get; set; }
        public System.DateTime StartDate { get; set; }
        public string LocationCoursework { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public System.DateTime EndDate { get; set; }
    
        public virtual Teacher Teacher { get; set; }
    }
}
