using FrontDeskApp.Interface;
using FrontDeskApp.Models;
using FrontDeskApp.Repositories;

namespace FrontDeskApp.Implementation
{
    public class CustomerBl : Repository<Customer>, ICustomer
    {
        public CustomerBl(FrontDeskContext context) : base(context)
        {

        }
    }
}
