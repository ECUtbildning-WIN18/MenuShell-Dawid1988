using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell.Domain;
using MenuShell.Services;

namespace MenuShell.View
{
    class DeleteUserView
    {
        private readonly IUserService _userService;

        private readonly IDictionary<string, User> _users;

        public DeleteUserView(IDictionary<string, User> users)
        {
            _users = users;
        }
        public void Display()
        {
            bool runMenu = true;
            
            do
            {
                // press ESC to go back to main menu

                Console.Clear();
                Console.WriteLine("# Delete Users\n");
                foreach (var user in _users)
                {
                    Console.WriteLine(user.Value.UserName);
                }
                
                Console.Write("\nDelete user: >_ ");
                var choice = Console.ReadLine();

                if (_users.ContainsKey(choice))
                {
                    _users.Remove(choice);
                }
                else
                {
                    runMenu = false;
                }
            } while (runMenu);

            Console.ReadLine();

        }
        
    }
}
