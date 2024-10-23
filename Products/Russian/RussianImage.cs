using abstract_factory.Interfaces;
using abstract_factory.Models;

namespace abstract_factory.Products.Russian
{
    public class RussianImage : IImage
    {
        public PhotoModel GetImagePath()
        {
            return new PhotoModel()
            {
                Images = new Dictionary<string, string> 
                { 
                    { "image-1-h", "/images/russian-1.jpg" }, 
                    { "image-2-v", "/images/russian-2.jpg" }, 
                    { "image-3-v", "/images/russian-3.jpg" }, 
                    { "image-4-v", "/images/russian-4.jpg" }, 
                    { "image-5-h", "/images/russian-5.jpg" }, 
                    { "image-6-h", "/images/russian-6.jpg" } 
                }               
            };
        }
    }
}
