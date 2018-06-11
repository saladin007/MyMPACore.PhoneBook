using System.Threading.Tasks;
using MyMPACore.PhoneBook.Configuration.Dto;

namespace MyMPACore.PhoneBook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
