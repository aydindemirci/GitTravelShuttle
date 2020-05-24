using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Core.Entities;

namespace TravelShuttle.Entities.Concrete
{
    public class Tag:IContext
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public string TagName{ get; set; }
    }
}
