using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ripley.legal.entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ripley.legal.repository.Mapping
{
    public class DocumentTypeMap : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.ToTable("DocumentType").HasKey(x => x.ID);
        }
    }
}
