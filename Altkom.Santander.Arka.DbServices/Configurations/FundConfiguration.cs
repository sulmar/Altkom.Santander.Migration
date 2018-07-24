using Altkom.Santander.Arka.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Santander.Arka.DbServices.Configurations
{
    class FundConfiguration : EntityTypeConfiguration<Fund>
    {
        public FundConfiguration()
        {
            ToTable("Fundusze");

            Property(p => p.Name)
               .IsRequired()
               .HasMaxLength(50)
               .HasColumnName("Nazwa");

         
        }
    }
}
