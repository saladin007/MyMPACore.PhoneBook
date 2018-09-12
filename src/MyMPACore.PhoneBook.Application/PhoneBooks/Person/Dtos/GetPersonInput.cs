using Abp.Runtime.Validation;
using MyMPACore.PhoneBook.Dto;

namespace MyMPACore.PhoneBook.PhoneBooks.Dtos
{
    public class GetPersonInput:PagedAndSortedInputDto,IShouldNormalize
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        public string FilterText { get; set; }
        //视图验证模型
        //ViewModel=>Dto=>model
        /// <summary>
        /// 排序规则
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
            
        }
    }
}