namespace abstract_factory.Interfaces
{
    public interface IText
    {
        List<string> GetHeaderContent(string culture);
        List<string> GetMainContent(string culture);
        List<string> GetFooterContent(string culture);
    }
}
