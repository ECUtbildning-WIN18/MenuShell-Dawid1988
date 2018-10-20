using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell.Domain;

namespace MenuShell.Services
{
    class FakeUserService : IUserService
    {
        private readonly IDictionary<string, User> 
            FakeData = new Dictionary<string, User>

            {
                { "dawid",
                new User(userName: "dawid",
                    password: "pwd",
                    role: Role.Administrator)
                    
                },

                {
                   "jane",
                    new User("jane","pwd2",
                       role: Role.User)
                },

                {
                    "adam",
                    new User("adam","pwd2",
                        role: Role.User)
                },

                {
                    "daniel",
                    new User("daniel","pwd2",
                        role: Role.User)
                },

                {
                    "dominik",
                    new User("dominik","pwd2",
                        role: Role.User)
                },

            };

        public IDictionary<string, User> LoadUsers()
        {
            return FakeData;
        }

    }
}
