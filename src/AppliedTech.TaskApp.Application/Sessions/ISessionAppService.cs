using System.Threading.Tasks;
using Abp.Application.Services;
using AppliedTech.TaskApp.Sessions.Dto;

namespace AppliedTech.TaskApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
