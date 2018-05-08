using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AppliedTech.TaskApp.Roles.Dto;

namespace AppliedTech.TaskApp.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
