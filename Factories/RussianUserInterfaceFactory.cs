using abstract_factory.Interfaces;
using abstract_factory.Products.Russian;

namespace abstract_factory.Factories
{
    public class RussianUserInterfaceFactory : IUserInterfaceFactory
    {
        public IText CreateText()
        {
            return new RussianText();
        }

        public IHelp CreateHelp()
        {
            throw new NotImplementedException();
        }

        public IImage CreateImage()
        {
            return new RussianImage();
        }        
    }
}
