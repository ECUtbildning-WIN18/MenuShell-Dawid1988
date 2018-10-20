using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Domain
{
    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(string userName, string password, Role role)
        {
            UserName = userName;
            Password = password;
            Role = role;
        }

        public override string ToString()
        {
            return "\nUserName: " + UserName + "\n" +
                   "Password: " + Password + "\n" +
                   "Role: " + Role;
        }
    }
}
