using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Core.Entities;
using TravelShuttle.Entities.Enums;

namespace TravelShuttle.Entities.Concrete
{
    public class Image:IContext
    {
        public int Id { get; set; }
        public int WebSiteId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Tag { get; set; }
        public string Url { get; set; }
        public ImageConstant? Constant { get; set; }
    }
}
