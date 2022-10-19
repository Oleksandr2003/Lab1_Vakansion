using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vakansion.Core
{
    public class Vacancys
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VacancysId { get; set; }

        public int PositionId { get; set; }
        public Position? Positions { get; set; }

        public int EmployerId { get; set; }
        public Employer? Employers { get; set; }

        public int UnemployedId { get; set; }
        public Unemployed? Unemployeds { get; set; }
    }
}
