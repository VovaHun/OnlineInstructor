using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Authentication
{
    public record class LoginRequest(string Email, string Password);
   
}
