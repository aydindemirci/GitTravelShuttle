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
    public class ImageManager : IImageService
    {
        private IImageDal _imageDal;
        private IGlobalVariable _globalVariable;
        public ImageManager(IImageDal imageDal, IGlobalVariable globalVariable)
        {
            _imageDal = imageDal;
            _globalVariable = globalVariable;
        }
        public void Add(Image image)
        {
            _imageDal.Add(image);
        }

        public void Delete(Image image)
        {
            _imageDal.Delete(image);
        }

        public List<Image> GetAll()
        {
            return _imageDal.GetList();
        }

        public Image GetImage(Int32 imageId)
        {
            try
            {
                return _imageDal.GetList(s=>s.Id == imageId && s.WebSiteId==_globalVariable.WebSiteId)[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Image GetImage(ImageConstant constant)
        {
            try
            {
                return _imageDal.GetList(s => s.Constant == constant && s.WebSiteId == _globalVariable.WebSiteId)[0];
            }
            catch (Exception e)
            {
                return null;
            }
            
        }

        public void Update(Image image)
        {
            _imageDal.Update(image);
        }
    }
}
