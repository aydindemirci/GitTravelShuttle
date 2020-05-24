using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.WebUI.Models
{
    public class AboutUsModel
    {
        public Definition definition { get; set; }
        public List<Customer> customers { get; set; }
    }
}
