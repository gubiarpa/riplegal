using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ripley.legal.entities.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ripley.legal.repository.Mapping
{
    public class LawFirmMap : IEntityTypeConfiguration<LawFirm>
    {
        public void Configure(EntityTypeBuilder<LawFirm> builder)
        {
            builder.ToTable("LawFirm").HasKey(x => x.ID);
        }
    }
}
