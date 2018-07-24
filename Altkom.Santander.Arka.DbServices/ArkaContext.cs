using Altkom.Santander.Arka.DbServices.Configurations;
using Altkom.Santander.Arka.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Santander.Arka.DbServices
{
    public class ArkaContext : DbContext
    {
        public ArkaContext()
            : base("ArkaConnection")
        {

        }

        public DbSet<Fund> Funds { get; set; }
        public DbSet<FundGroup> FundGroups { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new FundConfiguration());
            modelBuilder.Configurations.Add(new FundGroupConfiguration());
          

            base.OnModelCreating(modelBuilder);
        }

    }
}
