using Microsoft.EntityFrameworkCore;
using System;

namespace Chatify.Database
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            
        }
    }
}
