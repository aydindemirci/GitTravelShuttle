using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
