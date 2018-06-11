using System.Collections.Generic;
using MyMPACore.PhoneBook.Roles.Dto;

namespace MyMPACore.PhoneBook.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
