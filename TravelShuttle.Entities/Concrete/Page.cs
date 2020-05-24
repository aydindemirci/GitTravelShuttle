using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Core.Entities;
using TravelShuttle.Entities.Enums;

namespace TravelShuttle.Entities.Concrete
{
    public class Page:IContext
    {
        public int Id { get; set; }
        public int WebSiteId { get; set; }
        public PageType PageType { get; set; }
        public string Name { get; set; }
        public string UrlName { get; set; }
        public int? ImageId { get; set; }
        public DateTime? AddedDate { get; set; }
        public string Paragraph { get; set; }
        public string MiniParagraph { get; set; }
    }
}
