using System;
using System.Collections.Generic;
using System.Text;
using TravelShuttle.Entities.Concrete;
using TravelShuttle.Entities.Enums;

namespace TravelShuttle.Business.Abstract
{
    public interface IImageService
    {
        List<Image> GetAll();
        Image GetImage(Int32 imageId);
        Image GetImage(ImageConstant constant);
        void Add(Image image);
        void Update(Image image);
        void Delete(Image image);
    }
}
