using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontDeskApp.Models
{
    [Table("tblCategory")]
    public class Category
    {
        [Key]
        public int intCategoryId { get; set; }
        public string strCategory { get; set; }
        public int intLimit { get; set; }

        public ICollection<Package> Packages { get; set; }
    }
}
