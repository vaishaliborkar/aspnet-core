using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AppliedTech.TaskApp.Configuration;

namespace AppliedTech.TaskApp.Web.Startup
{
    [DependsOn(typeof(TaskAppWebCoreModule))]
    public class TaskAppWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TaskAppWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<TaskAppNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TaskAppWebMvcModule).GetAssembly());
        }
    }
}
