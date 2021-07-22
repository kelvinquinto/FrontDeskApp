using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontDeskApp.Models
{
    [Table("tblPackage")]
    public class Package
    {
        [Key]
        public int intPackageId { get; set; }
        public int intCustomerId { get; set; }
        public int intCategoryId { get; set; }
        public int intFacilityId { get; set; }
        public string strStatus { get; set; }
        public DateTime dtmDate { get; set; }

        public Category Category { get; set; }
        public Customer Customer { get; set; }
        public Facility Facility { get; set; }
    }
}
