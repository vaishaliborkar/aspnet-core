using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AppliedTech.TaskApp.Configuration;
using AppliedTech.TaskApp.Web;

namespace AppliedTech.TaskApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TaskAppDbContextFactory : IDesignTimeDbContextFactory<TaskAppDbContext>
    {
        public TaskAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TaskAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TaskAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TaskAppConsts.ConnectionStringName));

            return new TaskAppDbContext(builder.Options);
        }
    }
}
