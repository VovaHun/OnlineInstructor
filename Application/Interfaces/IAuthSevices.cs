
using Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    internal interface IAuthSevices
    {
        AuthResult Login (string username, string password);
        AuthResult Register (string firstName, string lastName, string email, string password);

    }
}
