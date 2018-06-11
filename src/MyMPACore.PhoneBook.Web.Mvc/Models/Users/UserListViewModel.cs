using System.Collections.Generic;
using MyMPACore.PhoneBook.Roles.Dto;
using MyMPACore.PhoneBook.Users.Dto;

namespace MyMPACore.PhoneBook.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
