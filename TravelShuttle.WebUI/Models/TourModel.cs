using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.WebUI.Models
{
    public class TourModel
    {
        public Page TourPage { get; set; }
        public List<Page> TourPages { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
