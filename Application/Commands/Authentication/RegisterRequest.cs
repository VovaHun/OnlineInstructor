using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Authentication
{
    public record class RegisterRequest(
            Guid Id,
            string FirstName,
            string LastName,
            string Email,
            string Password
        );
    
}
