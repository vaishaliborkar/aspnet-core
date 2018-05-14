using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AppliedTech.TaskApp.Authorization.Roles;
using AppliedTech.TaskApp.Authorization.Users;
using AppliedTech.TaskApp.MultiTenancy;
using AppliedTech.TaskApp.Tasks;
using AppliedTech.TaskApp.People;

namespace AppliedTech.TaskApp.EntityFrameworkCore
{
    public class TaskAppDbContext : AbpZeroDbContext<Tenant, Role, User, TaskAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Person> People { get; set; }
        public TaskAppDbContext(DbContextOptions<TaskAppDbContext> options)
            : base(options)
        {
        }
    }
}
