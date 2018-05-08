using System.ComponentModel.DataAnnotations;

namespace AppliedTech.TaskApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}