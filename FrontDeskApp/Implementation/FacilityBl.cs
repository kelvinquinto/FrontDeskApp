using System.Collections.Generic;
using System.Linq;
using FrontDeskApp.Interface;
using FrontDeskApp.Models;
using FrontDeskApp.Repositories;

namespace FrontDeskApp.Implementation
{
    public class FacilityBl : Repository<Facility>, IFacility
    {
        private readonly FrontDeskContext _context;

        public FacilityBl(FrontDeskContext context) : base(context)
        {
            _context = context;
        }

        public List<FacilityView> SearchFacilities()
        {
            var facilities = this.GetAll();
            var categories = _context.Categories.ToList();
            int intLimitSmall = categories.Where(w => w.strCategory.ToUpper() == "SMALL").Single().intLimit;
            int intLimitMedium = categories.Where(w => w.strCategory.ToUpper() == "MEDIUM").Single().intLimit;
            int intLimitLarge = categories.Where(w => w.strCategory.ToUpper() == "LARGE").Single().intLimit;

            var packages = _context.Packages                            
                                   .Where(w => (w.strStatus == "Stored" || w.strStatus == "Reserved"))
                                   .GroupBy(g => g.intFacilityId)
                                   .Select(s => new
                                   {
                                       intSmall = intLimitSmall - s.Count(a => a.intCategoryId == 1),
                                       intMedium = intLimitMedium - s.Count(a => a.intCategoryId == 2),
                                       intLarge = intLimitLarge - s.Count(a => a.intCategoryId == 3),
                                       intFacilityId = s.Max(m => m.intFacilityId)
                                   }).ToList();
            
            return (from fac in facilities
                    from avail in packages.Where(p => p.intFacilityId == fac.intFacilityId).DefaultIfEmpty()
                    select new FacilityView
                    {
                        intFacilityId = fac.intFacilityId,
                        strFacilityName = fac.strFacilityName,
                        intSmall = avail.intSmall,
                        intMedium = avail.intMedium,
                        intLarge = avail.intLarge
                    }).ToList();
        }
    }
}
