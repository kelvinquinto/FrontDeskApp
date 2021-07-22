using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontDeskApp.Models
{
    [Table("tblFacility")]
    public class Facility
    {
        [Key]
        public int intFacilityId { get; set; }
        public string strFacilityName { get; set; }

        public ICollection<Package> Packages { get; set; }
    }
}
