using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using AppliedTech.TaskApp.Authorization.Users;
using AppliedTech.TaskApp.Editions;

namespace AppliedTech.TaskApp.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
