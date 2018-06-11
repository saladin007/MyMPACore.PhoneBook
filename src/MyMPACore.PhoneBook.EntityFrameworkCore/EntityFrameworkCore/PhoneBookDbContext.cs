using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyMPACore.PhoneBook.Authorization.Roles;
using MyMPACore.PhoneBook.Authorization.Users;
using MyMPACore.PhoneBook.MultiTenancy;

namespace MyMPACore.PhoneBook.EntityFrameworkCore
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
            : base(options)
        {
        }
    }
}
