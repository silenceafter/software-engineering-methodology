using abstract_factory.Interfaces;

namespace abstract_factory.Services
{
    public interface LocalizedText : IText
    {
        public List<string> GetHeaderContent(string culture)
        {
            return LocalizedTexts.Translations[culture]["HeaderContent"];
        }

        public List<string> GetMainContent(string culture)
        {
            return LocalizedTexts.Translations[culture]["MainContent"];
        }

        public List<string> GetFooterContent(string culture)
        {
            return LocalizedTexts.Translations[culture]["FooterContent"];
        }
    }
}
