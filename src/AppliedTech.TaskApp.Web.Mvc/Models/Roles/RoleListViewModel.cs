using System.Collections.Generic;
using AppliedTech.TaskApp.Roles.Dto;

namespace AppliedTech.TaskApp.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
