using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyMPACore.PhoneBook.MultiTenancy.Dto;

namespace MyMPACore.PhoneBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
