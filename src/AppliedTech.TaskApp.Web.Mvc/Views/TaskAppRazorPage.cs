using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace AppliedTech.TaskApp.Web.Views
{
    public abstract class TaskAppRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TaskAppRazorPage()
        {
            LocalizationSourceName = TaskAppConsts.LocalizationSourceName;
        }
    }
}
