using System;
using System.Collections.Generic;
using MenuShell.Domain;

namespace MenuShell.View
{
    class AddUserView 
    {
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

                Console.WriteLine("UserName: ");
                var userName = Console.ReadLine();

                Console.WriteLine("\nPassword: ");
                var password = Console.ReadLine();

                Console.WriteLine("\nRole: ");
                var role = Console.ReadLine();

                Console.WriteLine("Is this correct ? (Y)es (N)o");
                var choice = Console.ReadKey();

                if (choice.Key == ConsoleKey.Y)
                { 
                    var user = new User(userName, password, (Role) Enum.Parse(typeof(Role), role));

                    if (!_users.ContainsKey(user.UserName))
                    {
                        _users.Add(user.UserName, user);
                        menuRun = false;
                    }
                }
                if (choice.Key == ConsoleKey.N)
                {
                    menuRun = false;
                    var add = new AddUserView(_users);
                    add.Display();
                }
                
        } while (menuRun);
            var main = new AdminMainView(_users);
            main.Display();
        }
        
    }
}
