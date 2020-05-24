using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Business.Abstract;
using TravelShuttle.Core;
using TravelShuttle.DataAccess.Abstract;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        private IGlobalVariable _globalVariable;
        private IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal,IGlobalVariable globalVariable)
        {
            _questionDal = questionDal;
            _globalVariable = globalVariable;
        }
        public void Add(Question question)
        {
            throw new NotImplementedException();
        }

        public void Delete(Question question)
        {
            throw new NotImplementedException();
        }

        public List<Question> GetAll()
        {
            return _questionDal.GetList(p=>p.WebSiteId==_globalVariable.WebSiteId);
        }

        public void Update(Question question)
        {
            throw new NotImplementedException();
        }
    }
}
