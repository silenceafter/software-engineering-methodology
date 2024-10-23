using abstract_factory.Interfaces;
using abstract_factory.Models;

namespace abstract_factory.Products.French
{
    public class FrenchImage : IImage
    {
        public PhotoModel GetImagePath()
        {
            return new PhotoModel()
            {
                Images = new Dictionary<string, string>
                {
                    { "image-1-h", "/images/french-1.jpg" },
                    { "image-2-v", "/images/french-2.jpg" },
                    { "image-3-v", "/images/french-3.jpg" },
                    { "image-4-v", "/images/french-4.jpg" },
                    { "image-5-h", "/images/french-5.jpg" },
                    { "image-6-h", "/images/french-6.jpg" }
                }
            };
        }
    }
}
