using Abp.AspNetCore.Mvc.ViewComponents;

namespace AppliedTech.TaskApp.Web.Views
{
    public abstract class TaskAppViewComponent : AbpViewComponent
    {
        protected TaskAppViewComponent()
        {
            LocalizationSourceName = TaskAppConsts.LocalizationSourceName;
        }
    }
}
