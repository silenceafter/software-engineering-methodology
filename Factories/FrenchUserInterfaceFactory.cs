using abstract_factory.Interfaces;
using abstract_factory.Products.French;
using abstract_factory.Products.Italian;
using abstract_factory.Products.Russian;

namespace abstract_factory.Factories
{
    public class FrenchUserInterfaceFactory : IUserInterfaceFactory
    {
        public IText CreateText()
        {
            return new FrenchText();
        }

        public IHelp CreateHelp()
        {
            throw new NotImplementedException();
        }

        public IImage CreateImage()
        {
            return new FrenchImage();
        }
    }
}
