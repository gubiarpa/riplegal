using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ripley.legal.entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ripley.legal.repository.Mapping
{
    public class DefenseAssessmentMap : IEntityTypeConfiguration<DefenseAssessment>
    {
        public void Configure(EntityTypeBuilder<DefenseAssessment> builder)
        {
            builder.ToTable("DefenseAssessment").HasKey(x => x.ID);
        }
    }
}
