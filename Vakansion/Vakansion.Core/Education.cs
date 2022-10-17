using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Vakansion.Core
{
    public class Education
    {
        [Key]
        public int ClassId { get; set; }
        public string? ClassName { get; set; }
    }
}
