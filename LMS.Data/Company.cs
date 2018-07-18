using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LMS.Data
{
    public partial class Company : BaseEntity
    {
      
        [StringLength(500)]
        public string NameEn { get; set; }
        [StringLength(500)]
        public string NameAr { get; set; }
        [StringLength(100)]
        public string CompanyLocation { get; set; }
        public int? CountryId { get; set; }
        [StringLength(100)]
        public string FaxNo { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string CompanyWebSite { get; set; }
        public int? IndustryTypeId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        //public virtual NamedCaller NamedCallers { get; set; }
    }
}
