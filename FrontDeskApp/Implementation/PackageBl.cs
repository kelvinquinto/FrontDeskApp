using System.Collections.Generic;
using System.Linq;
using FrontDeskApp.Interface;
using FrontDeskApp.Models;
using FrontDeskApp.Repositories;

namespace FrontDeskApp.Implementation
{
    public class PackageBl : Repository<Package>, IPackage
    {
        private readonly FrontDeskContext _context;

        public PackageBl(FrontDeskContext context) : base(context)
        {
            _context = context;
        }

        public List<PackageView> SearchPackages(int intCustomerId, int intFacilityId)
        {
            return _context.Packages
                           .Where(p => p.intCustomerId == intCustomerId && p.intFacilityId == intFacilityId)
                           .Select(s => new PackageView
                           {
                               intPackageId = s.intPackageId,
                               intPackageCustomerId = s.intCustomerId,
                               intPackageCategoryId = s.intCategoryId,
                               strPackageName = (s.Category.strCategory.ToUpper() == "SMALL" ? "S" : s.Category.strCategory.ToUpper() == "MEDIUM" ? "M" : "L") + "-" + s.intPackageId.ToString(),
                               strCategory = s.Category.strCategory,
                               strStatus = s.strStatus,
                               dtmDate = s.dtmDate                               
                           })
                           .OrderBy(o => o.dtmDate)
                           .ToList();
        }
    }
}
