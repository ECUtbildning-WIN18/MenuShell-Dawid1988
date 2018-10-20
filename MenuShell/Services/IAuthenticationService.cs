using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell.Domain;

namespace MenuShell.Services
{
    interface IAuthenticationService
    {
        User Authenticate(string userName, string password);
    }
}
