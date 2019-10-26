using _3thPartySoftware.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3thPartySoftware.DAL
{
    public class AsientosConfiguration : IEntityTypeConfiguration<AsientoExterno>
    {
        public void Configure(EntityTypeBuilder<AsientoExterno> builder)
        {
            builder.ToTable("AsientosExternos");

            builder.HasKey(x => x.IdAsiento);
        }
    }
}
