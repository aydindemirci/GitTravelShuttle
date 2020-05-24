using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Business.Abstract;
using TravelShuttle.Core;
using TravelShuttle.DataAccess.Abstract;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        private IGlobalVariable _globalVariable;
        public CustomerManager(ICustomerDal customerDal,IGlobalVariable globalVariable)
        {
            _customerDal = customerDal;
            _globalVariable = globalVariable;
        }
        public void Add(Customer customer)
        {
           _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetList(p => p.WebSiteId == _globalVariable.WebSiteId);
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
