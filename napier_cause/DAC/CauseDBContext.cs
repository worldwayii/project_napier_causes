using napier_cause.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace napier_cause.DAC
{
    public class CauseDBContext : DbContext
    {

        public CauseDBContext() : base("SchoolContext")
        {
        }

        public DbSet<Role> Roles { get; set; }

        public DbSet<ApplicationUser> Users {get; set;}

        public DbSet<Cause> Causes { get; set; }
       
        public DbSet<Signature> Signatures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}