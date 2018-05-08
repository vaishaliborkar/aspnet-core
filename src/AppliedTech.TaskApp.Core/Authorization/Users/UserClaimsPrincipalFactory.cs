using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using AppliedTech.TaskApp.Authorization.Roles;

namespace AppliedTech.TaskApp.Authorization.Users
{
    public class UserClaimsPrincipalFactory : AbpUserClaimsPrincipalFactory<User, Role>
    {
        public UserClaimsPrincipalFactory(
            UserManager userManager,
            RoleManager roleManager,
            IOptions<IdentityOptions> optionsAccessor)
            : base(
                  userManager,
                  roleManager,
                  optionsAccessor)
        {
        }
    }
}
