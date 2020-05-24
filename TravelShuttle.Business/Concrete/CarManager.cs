using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Business.Abstract;
using TravelShuttle.Core;
using TravelShuttle.DataAccess.Abstract;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;
        private IGlobalVariable _globalVariable;
        public CarManager(ICarDal carDal,IGlobalVariable globalVariable)
        {
            _globalVariable = globalVariable;
            _carDal = carDal;
        }
        public void Add(Car car)
        {
           _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetList(s=>s.WebSiteId==_globalVariable.WebSiteId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
