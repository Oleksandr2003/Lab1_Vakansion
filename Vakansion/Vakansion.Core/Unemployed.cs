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
        public Data? Datas { get; set; }
        public int EducationId { get; set; }
        public Education? Educations { get; set; }
        public virtual ICollection<Vacancys>? Vacancies { get; set; }
    }
}
