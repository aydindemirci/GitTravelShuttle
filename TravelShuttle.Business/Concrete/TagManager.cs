using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Business.Abstract;
using TravelShuttle.DataAccess.Abstract;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.Business.Concrete
{
    public class TagManager : ITagService
    {
        private ITagDal _tagDal;

        public TagManager(ITagDal tagDal)
        {
            _tagDal = tagDal;
        }
        public void Add(Tag tag)
        {
            _tagDal.Add(tag);
        }

        public void Delete(Tag tag)
        {
            _tagDal.Delete(tag);
        }

        public List<Tag> GetAll(int PageId)
        {
            return _tagDal.GetList(p=>p.PageId== PageId);
        }

        public void Update(Tag tag)
        {
            _tagDal.Update(tag);
        }
    }
}
