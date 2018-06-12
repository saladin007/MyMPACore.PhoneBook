using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using MyMPACore.PhoneBook.PhoneBooks.Persons;

namespace MyMPACore.PhoneBook.PhoneBooks.PhoneNumbers
{
    /// <summary>
    /// 电话号码
    /// </summary>
    public class PhoneNumber :Entity<long>,IHasCreationTime
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        [Required]
        [MaxLength(11)]
        public string Number { get; set; }
        /// <summary>
        /// 电话类型
        /// </summary>
        public PhoneNumberType Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Person Person { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
