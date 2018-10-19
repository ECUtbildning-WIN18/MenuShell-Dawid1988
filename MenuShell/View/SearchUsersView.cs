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

                // press ESC to go back to main menu

                foreach (var user in _users.Where(x => x.Value.UserName.Contains(searchTerm)))
                {
                    //Console.Clear();
                    //Console.WriteLine("Your search term match with: ");
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

                Console.Write("Delete>");
                var choice = Console.ReadLine();

                Console.WriteLine($"\nDelete user {choice} ? (D)elete");

                var presKey = Console.ReadKey();

                if (presKey.Key == ConsoleKey.D)
                {


                    Console.Clear();
                    if (_users.ContainsKey(choice))
                    {
                        _users.Remove(choice);
                    }

                    Thread.Sleep(1500);
                    

                }
                



            } while (run);
        }
        
    }
}
