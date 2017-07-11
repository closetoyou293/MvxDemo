using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvxDemo.Core.Infrastructure.Services.Interfaces;

namespace MvxDemo.Core.Infrastructure.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public bool LoggedIn { get; set; }
        public bool IsLoggedIn()
        {
            return LoggedIn;
        }
    }
}
