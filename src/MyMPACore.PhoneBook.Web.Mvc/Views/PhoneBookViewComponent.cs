using Abp.AspNetCore.Mvc.ViewComponents;

namespace MyMPACore.PhoneBook.Web.Views
{
    public abstract class PhoneBookViewComponent : AbpViewComponent
    {
        protected PhoneBookViewComponent()
        {
            LocalizationSourceName = PhoneBookConsts.LocalizationSourceName;
        }
    }
}
