using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelShuttle.Business.Abstract;
using TravelShuttle.Entities.Concrete;
using TravelShuttle.Entities.Enums;

namespace TravelShuttle.WebUI.MiddleWares
{
    public class WebFunctions
    {
        private IImageService _imageService;
        public WebFunctions(IImageService imageService)
        {
            _imageService = imageService;
        }
        private string ConvertImageTagProperty(Image image)
        {
            if (image == null)
                return "";

            string imageFile = !String.IsNullOrEmpty(image.Url) ? image.Url : "/WebFiles/Images/" + image.Name;
            return $"src= \"{imageFile}\" alt=\"{image.Tag}\" title=\"{image.Comment}\"";
        }
        public string GetImageTagProperty(int? imageId)
        {
            Image image = _imageService.GetImage(imageId.GetValueOrDefault());
            return ConvertImageTagProperty(image);
        }
        public string GetImageTagProperty(ImageConstant imageConstant)
        {
            Image image = _imageService.GetImage(imageConstant);
            return ConvertImageTagProperty(image);
        }
    }
}
