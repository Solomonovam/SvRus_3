using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SvRus_3.Models
{
    public class Photo
    {
        public Guid Id { get; set; }
        public string Head { get; set; }
        public string Descriptin { get; set; }
        public User EmployeePosted { get; set; }
        public string Path { get; set; }
    }
}
