using Abp.AutoMapper;
using MyMPACore.PhoneBook.Authentication.External;

namespace MyMPACore.PhoneBook.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
