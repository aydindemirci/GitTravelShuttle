using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Core.Entities;

namespace TravelShuttle.Entities.Concrete
{
    public class Customer:IContext
    {
        public int Id { get; set; }
        public int WebSiteId { get; set; }
        public string Name{ get; set; }
        public string Explanation { get; set; }
    }
}
