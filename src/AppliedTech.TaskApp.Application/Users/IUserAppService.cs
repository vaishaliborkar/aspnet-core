using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AppliedTech.TaskApp.Roles.Dto;
using AppliedTech.TaskApp.Users.Dto;

namespace AppliedTech.TaskApp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
