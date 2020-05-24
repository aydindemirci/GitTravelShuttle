using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.Business.Abstract
{
    public interface IQuestionService
    {
        List<Question> GetAll();
        void Add(Question question);
        void Update(Question question);
        void Delete(Question question);
    }
}
