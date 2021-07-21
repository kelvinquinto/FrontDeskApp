using System;

namespace FrontDeskApp.Models
{
    public class PackageView
    {
        public int intPackageId { get; set; }
        public int intPackageCustomerId { get; set; }
        public int intPackageCategoryId { get; set; }
        public string strPackageName { get; set; }
        public string strCategory { get; set; }
        public string strRetrieved { get; set; }
        public DateTime dtmDate { get; set; }
        public bool ysnRetrieved { get; set; }
    }
}
