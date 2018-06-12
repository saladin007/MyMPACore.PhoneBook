using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace MyMPACore.PhoneBook.Dto
{
    public class PagedAndSortedInputDto : IPagedResultRequest, ISortedResultRequest
    {
        /// <summary>
        /// 排序规则
        /// </summary>
        public string Sorting { get; set; }
        /// <summary>
        /// 跳页操作
        /// </summary>
        [Range(0,int.MaxValue)]
        public int SkipCount { get; set; }
        /// <summary>
        /// 每页显示最大数量
        /// </summary>
        [Range(1,500)]
        public int MaxResultCount { get; set; }
    }
}