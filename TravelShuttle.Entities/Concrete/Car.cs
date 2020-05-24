using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Core.Entities;

namespace TravelShuttle.Entities.Concrete
{
    public class Car : IContext
    {
        public int Id { get; set; }
        public int WebSiteId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int PassengerNumber { get; set; }
        public int ImageId { get; set; }
    }
}
