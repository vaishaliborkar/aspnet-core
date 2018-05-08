using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AppliedTech.TaskApp.EntityFrameworkCore
{
    public static class TaskAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TaskAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TaskAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
