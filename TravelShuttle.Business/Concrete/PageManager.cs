using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Business.Abstract;
using TravelShuttle.Core;
using TravelShuttle.DataAccess.Abstract;
using TravelShuttle.Entities.Concrete;
using TravelShuttle.Entities.Enums;

namespace TravelShuttle.Business.Concrete
{
    public class PageManager : IPageService
    {
        private IPageDal _pageDal;
        private IGlobalVariable _globalVariable;

        public PageManager(IPageDal pageDal,IGlobalVariable globalVariable)
        {
            _pageDal = pageDal;
            _globalVariable = globalVariable;
        }
        public void Add(Page page)
        {
            _pageDal.Add(page);
        }

        public void Delete(Page page)
        {
            _pageDal.Delete(page);
        }

        public List<Page> GetAll(PageType pageType)
        {
            return _pageDal.GetList(p=>p.PageType ==pageType
                                       && p.WebSiteId==_globalVariable.WebSiteId);
        }

        public void Update(Page page)
        {
            _pageDal.Update(page);
        }
    }
}
