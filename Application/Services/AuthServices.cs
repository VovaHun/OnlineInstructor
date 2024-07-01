using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    internal class AuthServices : IAuthSevices
    {
        public AuthResult Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public AuthResult Register(string firstName, string lastName, string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
