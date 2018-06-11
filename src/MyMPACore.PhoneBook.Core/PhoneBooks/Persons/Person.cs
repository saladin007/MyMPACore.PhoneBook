using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMPACore.PhoneBook.PhoneBooks.Persons
{
    /// <summary>
    /// 人员
    /// </summary>
    public class Person:FullAuditedEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// 地址信息
        /// </summary>
        public string Address { get; set; }
    }
}
