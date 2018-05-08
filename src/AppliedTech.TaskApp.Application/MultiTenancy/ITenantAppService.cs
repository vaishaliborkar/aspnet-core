using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AppliedTech.TaskApp.MultiTenancy.Dto;

namespace AppliedTech.TaskApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
