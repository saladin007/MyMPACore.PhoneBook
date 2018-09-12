using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using MyMPACore.PhoneBook.PhoneBooks.Persons;
using MyMPACore.PhoneBook.PhoneBooks.PhoneNumbers.Dto;

namespace MyMPACore.PhoneBook.PhoneBooks.Dtos
{
    //AutoMapTo将编辑的DTO转化成实体的DTO持久化到数据库中
    [AutoMapTo(typeof(Person))]
    public class PersonEditDto
    {
        public int? Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [EmailAddress]
        [MaxLength(80)]
        public string EmailAddress { get; set; }
        /// <summary>
        /// 地址信息
        /// </summary>
        [MaxLength(200)]
        public string Address { get; set; }

        public List<PhoneNumberEditDto> PhoneNumbers { get; set; }
    }
}