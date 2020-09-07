using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ripley.legal.entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ripley.legal.repository.Mapping
{
    public class DefendantMap : IEntityTypeConfiguration<Defendant>
    {
        public void Configure(EntityTypeBuilder<Defendant> builder)
        {
            builder.ToTable("Defendant").HasKey(x => x.ID);
        }
    }
}
