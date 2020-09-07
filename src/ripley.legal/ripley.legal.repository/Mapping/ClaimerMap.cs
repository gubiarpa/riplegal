using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ripley.legal.entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ripley.legal.repository.Mapping
{
    public class ClaimerMap : IEntityTypeConfiguration<Claimer>
    {
        public void Configure(EntityTypeBuilder<Claimer> builder)
        {
            builder.ToTable("Claimer").HasKey(x => x.ID);
        }
    }
}
