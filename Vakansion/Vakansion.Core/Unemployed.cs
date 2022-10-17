using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Vakansion.Core
{
    public class Unemployed
    {
        [Key]
        public int ClassId { get; set; }
        public string? ClassName { get; set; }
        public int DataId { get; set; }
        public virtual ICollection<Data>? Datas { get; set; }
        public int EducationId { get; set; }
        public virtual ICollection<Education>? Educations { get; set; }
    }
}
