using System.Collections.Generic;
using FrontDeskApp.Models;
using FrontDeskApp.Repositories;

namespace FrontDeskApp.Interface
{
    public interface IPackage : IRepository<Package>
    {
        List<PackageView> SearchPackages(int intCustomerId, int intFacilityId);
    }
}
