using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NetCoreMvc.Models
{
    public class DummyEFContext : DbContext
    {
        public DummyEFContext (DbContextOptions<DummyEFContext> options)
            : base(options)
        {
        }

        public DbSet<NetCoreMvc.Models.EmployeeViewModel> EmployeeViewModel { get; set; }
    }
}
