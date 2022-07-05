using BuberDinner.Application.Common.Interfaces.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Login(string Email, string Password)
        {
            return new AuthenticationResult(Guid.NewGuid(), "FirstName", "LastName", Email, "token");
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            var userID = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userID, firstName, lastName);
            return new AuthenticationResult(userID, firstName, lastName, email, token);
        }
    }
}
