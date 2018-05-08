using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AppliedTech.TaskApp.Controllers
{
    public abstract class TaskAppControllerBase: AbpController
    {
        protected TaskAppControllerBase()
        {
            LocalizationSourceName = TaskAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
