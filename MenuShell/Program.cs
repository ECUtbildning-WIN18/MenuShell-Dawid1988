using System.Collections.Generic;
using MenuShell.Services;
using MenuShell.View;

namespace MenuShell
{
    class Program
    {
        static void Main(string[] args)
        {
            var userService = new FakeUserService();

            var users = userService.LoadUsers();

            var authenticationService = new AuthenticationService(users);

            var login = new LogInView(authenticationService);

            login.Display();

            
            var admin = new AdminMainView(users);

                admin.Display();
            
            
            
            // TODO: Flytta in i AdminMainView
            //var add = new AddUserView(users);
            //var delete = new DeleteUserView();
            //add.Display();
            //delete.Display();            
        }
    }
}
