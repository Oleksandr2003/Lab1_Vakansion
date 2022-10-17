using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vakansion.Core
{
    public class Vacancy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VacancyId { get; set; }

        public int PositionId { get; set; }
        public virtual ICollection<Position>? Positions { get; set; }

        public int EmployerId { get; set; }
        public virtual ICollection<Employer>? Employers { get; set; }

        public int UnemployedId { get; set; }
        public virtual ICollection<Unemployed>? Unemployeds { get; set; }
    }
}
