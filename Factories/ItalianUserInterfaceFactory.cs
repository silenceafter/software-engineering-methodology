using abstract_factory.Interfaces;
using abstract_factory.Products.French;
using abstract_factory.Products.Italian;
using abstract_factory.Products.Russian;

namespace abstract_factory.Factories
{
    public class ItalianUserInterfaceFactory : IUserInterfaceFactory
    {
        public IText CreateText()
        {
            return new ItalianText();
        }

        public IHelp CreateHelp()
        {
            throw new NotImplementedException();
        }

        public IImage CreateImage()
        {
            return new ItalianImage();
        }
    }
}
