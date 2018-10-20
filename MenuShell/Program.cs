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
         
        }
    }
}
