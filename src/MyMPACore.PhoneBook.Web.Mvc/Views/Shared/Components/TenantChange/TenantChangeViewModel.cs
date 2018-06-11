using Abp.AutoMapper;
using MyMPACore.PhoneBook.Sessions.Dto;

namespace MyMPACore.PhoneBook.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
