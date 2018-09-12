using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyMPACore.PhoneBook.Controllers;
using MyMPACore.PhoneBook.PhoneBooks;
using MyMPACore.PhoneBook.PhoneBooks.Dtos;

namespace MyMPACore.PhoneBook.Web.Controllers
{
    public class PersonsController : PhoneBookControllerBase
    {
        private readonly IPersonAppService _personAppService;

        public PersonsController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        public async Task<IActionResult> Index(GetPersonInput input)
        {
         var dtos= await  _personAppService.GetPagedPersonAsync(input);
            return View(dtos);
        }
    }
}