using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.EntityMapper
{
     public class PartMap : IEntityTypeConfiguration<Part>
    {
        public void Configure(EntityTypeBuilder<Part> builder)
        {
            builder.HasKey(x => x.PartId);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
            builder.Property(x => x.SerialNr).HasMaxLength(50);
            builder.Property(x => x.Price).HasPrecision(9, 2);
        }

    }
}
