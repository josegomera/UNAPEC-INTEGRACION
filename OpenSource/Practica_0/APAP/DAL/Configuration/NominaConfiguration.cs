using APAP.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace APAP.DAL.Configuration
{
    public class NominaConfiguration : IEntityTypeConfiguration<Nomina>
    {
        public void Configure(EntityTypeBuilder<Nomina> builder)
        {
            builder.ToTable("Nominas");

            builder.HasKey(p => p.Id);
        }
    }
}
