﻿using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
