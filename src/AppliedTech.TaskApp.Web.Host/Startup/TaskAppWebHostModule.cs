using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AppliedTech.TaskApp.Configuration;

namespace AppliedTech.TaskApp.Web.Host.Startup
{
    [DependsOn(
       typeof(TaskAppWebCoreModule))]
    public class TaskAppWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TaskAppWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TaskAppWebHostModule).GetAssembly());
        }
    }
}
