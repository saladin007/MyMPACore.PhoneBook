using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using MyMPACore.PhoneBook.PhoneBooks.Dto;
using MyMPACore.PhoneBook.PhoneBooks.Persons;

namespace MyMPACore.PhoneBook.PhoneBooks
{
    public class PersonAppService: PhoneBookAppServiceBase,IPersonAppService
    {
        private readonly IRepository<Person> _personRepository;

        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            var query =_personRepository.GetAll();
            var personCount = await query.CountAsync();
            var persons= await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();
            //var listDto = new List<PersonListDto>();
            //foreach (var person in persons)
            //{
            //    var dto=new PersonListDto();
            //    dto.EmailAddress = person.EmailAddress;
            //}
            var dtos = persons.MapTo<List<PersonListDto>>();

            return new PagedResultDto<PersonListDto>(personCount,dtos);
        }

        public Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateOrUpdatePersonAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task DeletePersonAsync(EntityDto input)
        {
            throw new System.NotImplementedException();
        }
    }
}