using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SmartToDo.Models {
    public class User {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Group { get; set; }
    }
}
