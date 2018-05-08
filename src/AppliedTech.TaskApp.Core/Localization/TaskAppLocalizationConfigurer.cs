using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AppliedTech.TaskApp.Localization
{
    public static class TaskAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TaskAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TaskAppLocalizationConfigurer).GetAssembly(),
                        "AppliedTech.TaskApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
