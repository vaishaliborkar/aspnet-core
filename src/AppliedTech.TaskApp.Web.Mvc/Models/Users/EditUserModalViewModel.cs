using System.Collections.Generic;
using System.Linq;
using AppliedTech.TaskApp.Roles.Dto;
using AppliedTech.TaskApp.Users.Dto;

namespace AppliedTech.TaskApp.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
