using Vakansion.Core;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vacancy.Repository.Dto.UserDto
{
    public class UserRead
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsConfirmed { get; set; }
        public List<IdentityRole>? Roles { get; set; }
    }
}
