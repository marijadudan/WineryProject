using DL.AspNetIdentity;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IUserManager
    {
        IdentityResult CreateUser(ApplicationUser user, string password);
        IdentityResult AddToRole(string userId, string roleName);
    }
}
