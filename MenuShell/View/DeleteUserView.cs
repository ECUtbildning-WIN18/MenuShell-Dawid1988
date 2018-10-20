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
                Console.Clear();
                Console.WriteLine("# Delete Users\n");
                foreach (var user in _users)
                {
                    Console.WriteLine(user.Value.UserName);
                }
                
                Console.Write("\nDelete user: > ");
                
                var choice = Console.ReadLine();

                Console.WriteLine($"\nDo you want to delete user {choice} (Y)es (N)o, or press (ESC) to go back to main menu\n");

                var presKey = Console.ReadKey();

                if (presKey.Key == ConsoleKey.Y)
                {
                    if (_users.ContainsKey(choice))
                    {
                        _users.Remove(choice);
                    }
                }

                if (presKey.Key == ConsoleKey.N)
                {
                    runMenu = false;
                }

                if (presKey.Key == ConsoleKey.Escape)
                {
                    runMenu = false;
                    var admin = new AdminMainView(_users);
                    admin.Display();
                }
                
            } while (runMenu);

            Console.ReadLine();

        }
        
    }
}
