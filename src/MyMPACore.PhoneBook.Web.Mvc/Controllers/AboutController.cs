using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyMPACore.PhoneBook.Controllers;

namespace MyMPACore.PhoneBook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : PhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
