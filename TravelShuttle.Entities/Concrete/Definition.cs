using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Core.Entities;

namespace TravelShuttle.Entities.Concrete
{
    public class Definition :IContext
    {
        public int Id { get; set; }
        public int WebSiteId { get; set; }
        public string Title { get; set; }
        public string LogoTitle1 { get; set; }
        public string LogoTitle2{ get; set; }
        public string Twitter { get; set; }
        public string Facebook{ get; set; }
        public string Instagram{ get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
    }

}
