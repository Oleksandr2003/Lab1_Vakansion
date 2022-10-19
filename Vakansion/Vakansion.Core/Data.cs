using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Vakansion.Core
{
    public class Data
    {
        [Key]
        public int ClassId { get; set; }
        public string? ClassName { get; set; }

        public Unemployed? Unemployeds { get; set; }

        public virtual ICollection<Vacancys>? Vacancies { get; set; }
    }
}
