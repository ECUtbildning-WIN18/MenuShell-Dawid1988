using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell.Domain;


namespace MenuShell.Services
{

    class AuthenticationService : IAuthenticationService
    {
        
        private readonly IUserService _userService;

        private IDictionary<string, User> _users;

        public AuthenticationService(IDictionary<string, User> users)
        {
            _users = users;
        }
    
        public User Authenticate(string userName, string password)
        {
            User user = null;
            
            if (_users.ContainsKey(userName) && _users[userName].Password == password)
            {
                user = _users[userName];

            }
            return  user;
        } 
    }
}
