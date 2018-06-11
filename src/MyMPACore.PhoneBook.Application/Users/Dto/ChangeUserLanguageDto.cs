using System.ComponentModel.DataAnnotations;

namespace MyMPACore.PhoneBook.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}