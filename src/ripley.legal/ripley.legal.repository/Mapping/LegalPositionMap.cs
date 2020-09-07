using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ripley.legal.entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ripley.legal.repository.Mapping
{
    public class LegalPositionMap : IEntityTypeConfiguration<LegalPosition>
    {
        public void Configure(EntityTypeBuilder<LegalPosition> builder)
        {
            builder.ToTable("LegalPosition").HasKey(x => x.ID);
        }
    }
}
