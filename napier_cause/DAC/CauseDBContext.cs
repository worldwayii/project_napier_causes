using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using napier_cause.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace napier_cause.DAC
{
    public class CauseDBContext : DbContext
    {
       

        
        public DbSet<Cause> Causes { get; set; }
       
        public DbSet<Signature> Signatures { get; set; }
      

    }
}