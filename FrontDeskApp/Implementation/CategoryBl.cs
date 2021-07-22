using System.Collections.Generic;
using System.Linq;
using FrontDeskApp.Interface;
using FrontDeskApp.Models;
using FrontDeskApp.Repositories;

namespace FrontDeskApp.Implementation
{
    public class CategoryBl : Repository<Category>, ICategory
    {
        private readonly FrontDeskContext _context;

        public CategoryBl(FrontDeskContext context) : base(context)
        {
            _context = context;
        }

        public List<AvailableSlotView> GetAvailableSlots(int intFacilityId)
        {
            var categories = this.GetAll();
            var packages = _context.Packages
                                   .Where(w => (w.strStatus == "Stored" || w.strStatus == "Reserved") && w.intFacilityId == intFacilityId)
                                   .GroupBy(g => g.intCategoryId)
                                   .Select(s => new
                                   {
                                       intCount = s.Count(),
                                       intCategoryId = s.Max(m => m.intCategoryId)
                                   }).ToList();

            return (from cat in categories
                    from package in packages.Where(p => p.intCategoryId == cat.intCategoryId).DefaultIfEmpty()
                    select new AvailableSlotView
                    {
                        intLimit = cat.intLimit,
                        intAvailable = cat.intLimit - (package != null ? package.intCount : 0),
                        strCategory = cat.strCategory 
                    }).ToList();
        }
    }
}
