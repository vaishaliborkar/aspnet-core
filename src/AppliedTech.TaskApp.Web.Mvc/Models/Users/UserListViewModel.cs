using System.Collections.Generic;
using AppliedTech.TaskApp.Roles.Dto;
using AppliedTech.TaskApp.Users.Dto;

namespace AppliedTech.TaskApp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
