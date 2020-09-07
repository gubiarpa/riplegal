using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ripley.legal.entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ripley.legal.repository.Mapping
{
    public class ProcessTypeMap : IEntityTypeConfiguration<ProcessType>
    {
        public void Configure(EntityTypeBuilder<ProcessType> builder)
        {
            builder.ToTable("ProcessType").HasKey(x => x.ID);
        }
    }
}
