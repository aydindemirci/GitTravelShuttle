using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Entities.Concrete;
using TravelShuttle.Entities.Enums;

namespace TravelShuttle.Business.Abstract
{
    public interface IPageService
    {
        List<Page> GetAll(PageType pageType);
        void Add(Page page);
        void Update(Page page);
        void Delete(Page page);
    }
}
