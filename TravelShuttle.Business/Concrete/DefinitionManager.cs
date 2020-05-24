using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Business.Abstract;
using TravelShuttle.Core;
using TravelShuttle.Core.Entities;
using TravelShuttle.DataAccess.Abstract;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.Business.Concrete
{
    public class DefinitionManager : IDefinitionService
    {
        private IDefinitionDal _definitionDal;
        private IGlobalVariable _globalVariable;
        public DefinitionManager(IDefinitionDal definitionDal,IGlobalVariable globalVariable)
        {
            _definitionDal = definitionDal;
            _globalVariable = globalVariable;
        }

        public Definition GetDefinition()
        {
            try
            {
                return _definitionDal.GetList(p => p.WebSiteId == _globalVariable.WebSiteId)[0];
            }
            catch
            {
                return new Definition();
            }
            
        }

    }
}
