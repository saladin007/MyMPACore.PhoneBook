using System.ComponentModel.DataAnnotations;

namespace MyMPACore.PhoneBook.PhoneBooks.Dto
{
    public class PersonEditDto
    {
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
    }
}