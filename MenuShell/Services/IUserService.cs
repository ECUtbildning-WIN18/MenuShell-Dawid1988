using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell.Domain;

namespace MenuShell.Services
{
    interface IUserService
    {
        IDictionary<string, User> LoadUsers();
    }
}
