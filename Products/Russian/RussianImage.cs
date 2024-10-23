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
                    { "Moscow-1-h", "/images/russian-1.jpg" }, 
                    { "Moscow-2-v", "/images/russian-2.jpg" }, 
                    { "SaintPetersburg-3-v", "/images/russian-3.jpg" }, 
                    { "SaintPetersburg-4-v", "/images/russian-4.jpg" }, 
                    { "Kazan-5-h", "/images/russian-5.jpg" }, 
                    { "Moscow-6-h", "/images/russian-6.jpg" } 
                }               
            };
        }
    }
}
