using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SvRus_3.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneWork { get; set; }
        public string Password { get; set; }
        public bool RoleAdmin { get; set; }

        //public string CheckUser { get; set; }

    }
}
