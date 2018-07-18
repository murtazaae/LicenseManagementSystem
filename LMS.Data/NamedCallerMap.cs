using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Data
{
   public class NamedCallerMap
    {
        public NamedCallerMap(EntityTypeBuilder<NamedCaller> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(e => e.Id);
            entityTypeBuilder.Property(e => e.AddedDate);
            entityTypeBuilder.Property(e => e.Companies);
            entityTypeBuilder.HasOne(e => e.Companies).WithOne(n => n.NamedCallers).HasForeignKey<Company>(x => x.Id);
            entityTypeBuilder.Property(e => e.CompanyID).IsRequired();
            entityTypeBuilder.Property(e => e.Email).IsRequired();
            entityTypeBuilder.Property(e => e.FirstNameAR);
            entityTypeBuilder.Property(e => e.FirstNameEN).IsRequired();
            entityTypeBuilder.Property(e => e.IPAddress);
            entityTypeBuilder.Property(e => e.LastNameAR);
            entityTypeBuilder.Property(e => e.LastNameEN);
            entityTypeBuilder.Property(e => e.MiddleNameAR);
            entityTypeBuilder.Property(e => e.MiddleNameEN);
            entityTypeBuilder.Property(e => e.ModifiedDate);
            entityTypeBuilder.Property(e => e.PrimaryPhoneNumber).IsRequired();
            
        }
    }
}
