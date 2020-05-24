using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Core.Entities;

namespace TravelShuttle.Entities.Concrete
{
    public class Question:IContext
    {
        public int Id { get; set; }
        public int WebSiteId { get; set; }
        public string QuestionName { get; set; }
        public string Answer { get; set; }
    }
}
