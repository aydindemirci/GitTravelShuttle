using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Core.DataAccess.EntityFramework;
using TravelShuttle.DataAccess.Abstract;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:EfEntityRepositoryBase<Car,TravelContext>,ICarDal
    {

    }
}
