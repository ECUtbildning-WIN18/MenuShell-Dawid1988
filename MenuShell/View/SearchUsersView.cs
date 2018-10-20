using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MenuShell.Domain;
using MenuShell.Services;

namespace MenuShell.View
{
    class SearchUsersView
    {
        private readonly IUserService _userService;

        private readonly IDictionary<string, User> _users;

        public SearchUsersView(IDictionary<string, User> users)
        {
            _users = users;
        }
        
        public void Display()
        {
            bool run = true;
            do
            {
                bool Inlist = false;
                Console.Clear();
                Console.Write("Search term: >");
                string searchTerm = Console.ReadLine();
                
                foreach (var user in _users.Where(x => x.Value.UserName.Contains(searchTerm)))
                {
                   
                    Console.WriteLine(user.Value.UserName);
                    Inlist = true;
                    
                }
                if (!Inlist)
                {
                    Console.Clear();
                    Console.WriteLine($"No users found matching the: {searchTerm}");

                    Thread.Sleep(4000);

                    var upp = new SearchUsersView(_users);
                    upp.Display();
                }

                Console.Write("\nSelect user> ");
                var choice = Console.ReadLine();

                Console.WriteLine($"\n(D)elete or (V)iew user {choice} ? ");

                Console.WriteLine("Press (ESC) to go back to main menu");

                var presKey = Console.ReadKey();

                if (presKey.Key == ConsoleKey.D)
                {
                    
                    Console.Clear();

                    if (_users.ContainsKey(choice))
                    {
                        _users.Remove(choice);
                    }

                    Console.WriteLine($"User {choice} successfully deleted");
                    Thread.Sleep(1500);

                }
                if (presKey.Key == ConsoleKey.V)
                {

                    Console.Clear();
                    if (_users.ContainsKey(choice))
                    {
                        var value = _users[choice];
                        Console.WriteLine( choice + value);
                        Console.ReadKey();
                    }
        
                }

                if (presKey.Key == ConsoleKey.Escape) 
                {
                    run = false;
                    var admin = new AdminMainView(_users);
                    admin.Display();
                }

            } while (run);
        }
        
    }
}
