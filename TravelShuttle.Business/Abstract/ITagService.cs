using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.Business.Abstract
{
    public interface ITagService
    {
        List<Tag> GetAll(int PageId);
        void Add(Tag tag);
        void Update(Tag tag);
        void Delete(Tag tag);
    }
}
