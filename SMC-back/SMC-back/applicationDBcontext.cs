using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMC_back.Entities;

namespace SMC_back
{
    public class applicationDBcontext : IdentityDbContext
    {
        public applicationDBcontext(DbContextOptions<applicationDBcontext> options) : base(options) {
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Staff> Staff { get; set; }

        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            base.OnModelCreating(optionsBuilder);
            optionsBuilder.Entity<Person>()
            .HasOne(p => p.Staff)
            .WithOne(p => p.Person)
            .HasForeignKey<Person>(s => s.StaffID);
        }
    }
}
