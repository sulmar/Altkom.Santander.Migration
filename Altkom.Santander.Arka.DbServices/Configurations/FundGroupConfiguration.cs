using Altkom.Santander.Arka.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Santander.Arka.DbServices.Configurations
{
    class FundGroupConfiguration : EntityTypeConfiguration<FundGroup>
    {
        public FundGroupConfiguration()
        {
            //Property(p => p.Name)
            //  .IsRequired()
            //  .HasMaxLength(100);
        }
    }
}
