using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ripley.legal.entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ripley.legal.repository.Mapping
{
    public class TypologyMap : IEntityTypeConfiguration<Typology>
    {
        public void Configure(EntityTypeBuilder<Typology> builder)
        {
            builder.ToTable("Typology").HasKey(x => x.ID);
        }
    }
}
