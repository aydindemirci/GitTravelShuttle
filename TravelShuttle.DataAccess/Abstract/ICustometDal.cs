﻿using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Core.DataAccess;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {

    }
}