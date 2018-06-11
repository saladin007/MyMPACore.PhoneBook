using Abp.Authorization;
using MyMPACore.PhoneBook.Authorization.Roles;
using MyMPACore.PhoneBook.Authorization.Users;

namespace MyMPACore.PhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
