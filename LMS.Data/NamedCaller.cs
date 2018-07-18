using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LMS.Data
{
    public class NamedCaller :BaseEntity
    {
        public string FirstNameEN { get; set; }
        public string MiddleNameEN { get; set; }
        public string LastNameEN { get; set; }
        public string FirstNameAR { get; set; }
        public string MiddleNameAR { get; set; }
        public string LastNameAR { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string Email { get; set; }

        [ForeignKey("Companies")]
        public int CompanyID { get; set; }
        public virtual Company Companies { get; set; }

    }
}
