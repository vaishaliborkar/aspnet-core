using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AppliedTech.TaskApp.Configuration;
using AppliedTech.TaskApp.EntityFrameworkCore;
using AppliedTech.TaskApp.Migrator.DependencyInjection;

namespace AppliedTech.TaskApp.Migrator
{
    [DependsOn(typeof(TaskAppEntityFrameworkModule))]
    public class TaskAppMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public TaskAppMigratorModule(TaskAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(TaskAppMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                TaskAppConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TaskAppMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
