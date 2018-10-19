using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell.Domain;

namespace MenuShell.View
{
    class AddUserView 
    {
        //Dictionary<string, Users> usersList = new Dictionary<string, Users>();

        private readonly IDictionary<string, User> _users;

        public AddUserView(IDictionary<string, User> users)
        {
            _users = users;
        }
       
        public void Display()
        {
            bool menuRun = true;
            
                do
                {
                   Console.Clear();
                   Console.WriteLine("# Add user\n");
                   
                   Console.WriteLine("UserName");
                   var userName = Console.ReadLine();

                   Console.WriteLine("Password");
                   var password = Console.ReadLine();

                   Console.WriteLine("Role");
                   var role = Console.ReadLine();

                   //Console.WriteLine("Is this correct ? (Y)es (N)o");
                   //var choice = Console.ReadKey(true);

                    var user = new User(userName, password, (Role) Enum.Parse(typeof(Role), role));

                     if (!_users.ContainsKey(user.UserName))
                     {
                         _users.Add(user.UserName, user);
                         menuRun = false;
                     }

                } while (menuRun);
            var main = new AdminMainView(_users);
            main.Display();
        }
        
    }
}
