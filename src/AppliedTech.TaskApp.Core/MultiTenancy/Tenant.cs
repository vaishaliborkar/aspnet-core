using Abp.MultiTenancy;
using AppliedTech.TaskApp.Authorization.Users;

namespace AppliedTech.TaskApp.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
