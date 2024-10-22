namespace abstract_factory.Interfaces
{
    public interface IUserInterfaceFactory
    {
        IText CreateText();
        IImage CreateImage();
        IHelp CreateHelp();
    }
}
