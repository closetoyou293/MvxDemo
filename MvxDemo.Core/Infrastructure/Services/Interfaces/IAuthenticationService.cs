using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvxDemo.Core.Infrastructure.Services.Interfaces
{
    public interface IAuthenticationService
    {
        bool LoggedIn { get; set; }
        bool IsLoggedIn();
    }
}
