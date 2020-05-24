using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.WebUI.Models
{
    public class WebSiteModel
    {
        public Definition definition { get; set; }
        public List<Page> services { get; set; }
        public List<Page> tours { get; set; }
    }
}
