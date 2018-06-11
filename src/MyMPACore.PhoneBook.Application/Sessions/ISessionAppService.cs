using System.Threading.Tasks;
using Abp.Application.Services;
using MyMPACore.PhoneBook.Sessions.Dto;

namespace MyMPACore.PhoneBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
