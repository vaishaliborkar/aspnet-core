using System.Threading.Tasks;
using AppliedTech.TaskApp.Configuration.Dto;

namespace AppliedTech.TaskApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
