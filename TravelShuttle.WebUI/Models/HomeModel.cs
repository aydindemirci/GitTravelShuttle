using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.WebUI.Models
{
    public class HomeModel
    {
        public List<Car> Cars { get; set; }

        public List<Page>BlogsPages { get; set; }
    }
}
