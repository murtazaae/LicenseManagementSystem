using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Data
{
    public class CompanyMap
    {
        public CompanyMap(EntityTypeBuilder<Company> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.AddedDate);
            entityTypeBuilder.Property(t => t.CompanyLocation);
            entityTypeBuilder.Property(t => t.CompanyWebSite);
            entityTypeBuilder.Property(t => t.CountryId);
            entityTypeBuilder.Property(t => t.Email).IsRequired();
            entityTypeBuilder.Property(t => t.FaxNo);
            entityTypeBuilder.Property(t => t.IndustryTypeId);
            entityTypeBuilder.Property(t => t.IsActive);
            entityTypeBuilder.Property(t => t.IsDeleted);
            entityTypeBuilder.Property(t => t.NameAr);
            entityTypeBuilder.Property(t => t.NameEn).IsRequired();
            entityTypeBuilder.Property(t => t.RegistrationDate).IsRequired();
            
        }

    }
}
