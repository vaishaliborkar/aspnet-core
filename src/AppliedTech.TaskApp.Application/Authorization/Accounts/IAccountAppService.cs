using System.Threading.Tasks;
using Abp.Application.Services;
using AppliedTech.TaskApp.Authorization.Accounts.Dto;

namespace AppliedTech.TaskApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
