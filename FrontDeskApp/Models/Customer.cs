using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontDeskApp.Models
{
    [Table("tblCustomer")]
    public class Customer
    {
        [Key]
        public int intCustomerId { get; set; }
        public string strFirstName { get; set; }
        public string strLastName { get; set; }
        public string strPhoneNumber { get; set; }

        public ICollection<Package> Packages { get; set; }
    }
}
