using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class LogInView
    {

        public static void LoginDisplay()
        {
            bool logginSucces = false;
            do
            { 
            Console.Write("Username:");
            string username = Console.ReadLine();
            Console.Write("Password:");
            string password = Console.ReadLine();

            Console.WriteLine("\nIs this correct? (Y)es (N)o");

            var keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Y)
            {
                if ()
                {
                    

                }
                else
                {
                    Console.WriteLine("Wrong Username or Password");
                    System.Threading.Thread.Sleep(2000);
                }
            }
            else if (keyInfo.Key == ConsoleKey.N)
            {
                //
            }
            else
            {
                Console.WriteLine("Invalid selction !");
            }

        } while (!logginSucces);

        }


    }
}
