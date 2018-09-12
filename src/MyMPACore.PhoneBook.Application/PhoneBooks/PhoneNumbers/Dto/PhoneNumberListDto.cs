using Abp.AutoMapper;

namespace MyMPACore.PhoneBook.PhoneBooks.PhoneNumbers.Dto
{
    [AutoMapFrom(typeof(PhoneNumber))]
    public class PhoneNumberListDto
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 电话类型
        /// </summary>
        public PhoneNumberType Type { get; set; }
    }
}