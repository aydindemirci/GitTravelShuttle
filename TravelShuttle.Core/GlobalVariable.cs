using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace TravelShuttle.Core
{
    public class GlobalVariable: IGlobalVariable
    {
        public GlobalVariable(IConfiguration configuration)
        {
            var travelConfiguration = configuration.GetSection("TravelConfiguration");
            WebSiteId = Convert.ToInt32(travelConfiguration["WebSiteId"]);
        }
        public int WebSiteId { get; set; }
    }

    public interface IGlobalVariable
    {
        int WebSiteId { get; set; }
    }
}
