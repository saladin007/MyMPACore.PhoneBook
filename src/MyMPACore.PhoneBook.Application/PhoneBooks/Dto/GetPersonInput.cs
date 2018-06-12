using Abp;
using Abp.Runtime.Validation;
using Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal;
using MyMPACore.PhoneBook.Dto;

namespace MyMPACore.PhoneBook.PhoneBooks.Dto
{
    public class GetPersonInput:PagedAndSortedInputDto,IShouldNormalize
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        public string FilterText { get; set; }

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