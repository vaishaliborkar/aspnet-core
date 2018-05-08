using Abp.Authorization;
using AppliedTech.TaskApp.Authorization.Roles;
using AppliedTech.TaskApp.Authorization.Users;

namespace AppliedTech.TaskApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
