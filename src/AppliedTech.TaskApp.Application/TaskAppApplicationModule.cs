using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AppliedTech.TaskApp.Authorization;

namespace AppliedTech.TaskApp
{
    [DependsOn(
        typeof(TaskAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TaskAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TaskAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TaskAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
