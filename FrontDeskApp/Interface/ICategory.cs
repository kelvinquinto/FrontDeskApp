using System.Collections.Generic;
using FrontDeskApp.Models;
using FrontDeskApp.Repositories;

namespace FrontDeskApp.Interface
{
    public interface ICategory : IRepository<Category>
    {
        List<AvailableSlotView> GetAvailableSlots();
    }
}
