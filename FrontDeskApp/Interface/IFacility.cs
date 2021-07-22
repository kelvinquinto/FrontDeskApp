using System.Collections.Generic;
using FrontDeskApp.Models;
using FrontDeskApp.Repositories;

namespace FrontDeskApp.Interface
{
    public interface IFacility : IRepository<Facility>
    {
        List<FacilityView> SearchFacilities();
    }
}
