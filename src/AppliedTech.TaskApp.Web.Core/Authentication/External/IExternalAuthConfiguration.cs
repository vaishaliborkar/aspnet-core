using System.Collections.Generic;

namespace AppliedTech.TaskApp.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
