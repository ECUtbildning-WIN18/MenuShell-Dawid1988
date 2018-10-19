using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MenuShell.Domain;

namespace MenuShell.View
{
    class AdminMainView
    {
        private IDictionary<string, User>_users;
        public AdminMainView(IDictionary<string, User> users)
        {
            _users = users;
        }
        public string Display()
        {
            Console.Clear();
            Console.WriteLine("# Main menu\n");
            Console.WriteLine("1 Add Users");
            Console.WriteLine("2 Delete Users - MenuShell 1.0");
            Console.WriteLine("3 Search users - MenuShell 1.1");
            Console.WriteLine("4 Exit");

            var consoleKeyInfo = Console.ReadKey(true);

            bool runMenu = true;
            
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:
                    {
                        Console.Clear();
                        Console.WriteLine("1 Add Users");
                        Thread.Sleep(1000);
                        var add = new AddUserView(_users);
                        add.Display();
                        return "1";
                    }

                    case ConsoleKey.D2:
                    {
                        Console.Clear();
                        Console.WriteLine("2 Delete Users");
                        Thread.Sleep(1000);
                        var delete = new DeleteUserView(_users);
                        delete.Display();
                        return "2";
                    }

                    case ConsoleKey.D3:
                    {
                        Console.Clear();
                        Console.WriteLine("Search users");
                        var search = new SearchUsersView(_users);
                        search.Display();
                        return "3";
                    }



                    case ConsoleKey.D4:
                    {
                        Console.Clear();
                        Console.WriteLine("Exit program");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                    }
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("You can use only numbers from menu ");
                        var main = new AdminMainView(_users);
                        main.Display();
                        Thread.Sleep(1000);
                    break;
                }
            
                return "";
            
        }
        
    }
}
