using Microsoft.EntityFrameworkCore;
using OjasTimeSheetManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OjasTimeSheetManagement.Concrete
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options)
        {}
        public DbSet<Role> Role { get; set; }
    }
}
