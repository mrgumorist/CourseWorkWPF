using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWPF
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime dateOfBith { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime dateOfStartWorking { get; set; }
        public string Range { get; set; }
        public bool IsBanned { get; set; }
        public bool IsAccepted { get; set; }
        public User()
        {

        }
    }
}
