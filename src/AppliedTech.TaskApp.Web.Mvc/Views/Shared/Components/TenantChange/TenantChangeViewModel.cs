using Abp.AutoMapper;
using AppliedTech.TaskApp.Sessions.Dto;

namespace AppliedTech.TaskApp.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
