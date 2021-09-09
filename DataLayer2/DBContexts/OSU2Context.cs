using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BusinessEntities;
using BusinessEntities.Entities;

namespace DataLayer
{
    public class OSU2Context : DbContext
    {
        public DbSet<ActivityDto> Activities { get; set; }
        public DbSet<AdminDto> Admins { get; set; }
        public DbSet<AlumnusDto> Alumni { get; set; }
        public DbSet<EmployeeDto> Employees { get; set; }
        public DbSet<MailingDto> Mailings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
