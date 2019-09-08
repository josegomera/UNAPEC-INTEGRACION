using APEC.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace APEC.DAL
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
