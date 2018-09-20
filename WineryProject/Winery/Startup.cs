using BL.Interfaces;
using BL.Repository;
using DL.AspNetIdentity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Winery.Startup))]
namespace Winery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers(new RoleManagerRepository(), new UserMenagerRepository());
        }

        private void createRolesandUsers(IRoleManager _roleManagerRepository, IUserManager _userManagerRepository)
        {

            // In Startup iam creating first Admin Role and creating a default Admin User    
            if (!_roleManagerRepository.RoleExists("Admin"))
            {

                // first we create Admin rool   
                var role = new IdentityRole();
                role.Name = "Admin";
                _roleManagerRepository.CreateRole(role);

                //Here we create a Admin super user who will maintain the website                  

                var user = new ApplicationUser();
                user.UserName = "vegawine@gmail.com";
                user.Email = "vegawine@gmail.com";

                string userPWD = "123456";

                var chkUser = _userManagerRepository.CreateUser(user, userPWD);

                //Add default User to Role Admin   
                if (chkUser.Succeeded)
                {
                    var result1 = _userManagerRepository.AddToRole(user.Id, "Admin");

                }
            }

            // creating Creating Manager role    
            //if (!_roleManagerRepository.RoleExists("Manager"))
            //{
            //    var role = new IdentityRole();
            //    role.Name = "Manager";
            //    _roleManagerRepository.CreateRole(role);

            //}

            // creating Creating User role    
            if (!_roleManagerRepository.RoleExists("User"))
            {
                var role = new IdentityRole();
                role.Name = "User";
                _roleManagerRepository.CreateRole(role);
            }
        }
    }
}
