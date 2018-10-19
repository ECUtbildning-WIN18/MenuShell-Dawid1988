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
    class LogInView
    {
        private readonly IAuthenticationService _authenticationService;

        public LogInView(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public void Display()
        {
            User user = null;

            do
            {
                Console.Clear();
                Console.WriteLine("# Please Login\n");
                
                Console.Write("Username:");
                string userName = Console.ReadLine();
                
                Console.Write("Password:");
                string password = Console.ReadLine();

                Console.WriteLine("\nIs this correct? (Y)es (N)o\n");

                var presKey = Console.ReadKey();

                if (presKey.Key == ConsoleKey.Y)
                {
                    
                    user = _authenticationService.Authenticate(userName, password);

                    if (user != null)
                    {
                        Console.Clear();
                        Console.WriteLine("Successfully logged in! ");
                        Console.WriteLine($"Role : {user.Role}");
                        Thread.Sleep(2000);
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Access denied! ");
                        Thread.Sleep(4000);
                    }
                    
                    if  (presKey.Key == ConsoleKey.N)
                    {
                        Console.Clear();
                        Console.WriteLine("Back to Login menu ");
                        Thread.Sleep(2000);
                    }

                }

            } while (user == null);
        }
    }
}
