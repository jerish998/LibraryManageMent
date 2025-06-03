using LibraryManagementSys.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryManagementSys.DbContextApp
{
    public class DbConnectionAppContext : DbContext
    {
        public DbConnectionAppContext(DbContextOptions<DbConnectionAppContext> options)
            : base(options) { }


       public DbSet<User> Users { get; set; }
    }
}
