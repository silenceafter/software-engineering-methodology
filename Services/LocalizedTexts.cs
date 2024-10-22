namespace abstract_factory.Services
{
    public interface LocalizedTexts
    {
        public static readonly Dictionary<string, Dictionary<string, List<string>>> Translations = new()
        {
            { "en", new Dictionary<string, List<string>>
                {
                    { "Header_Menu", new List<string> { "Home", "Help", "About" } },
                    { "Footer_Menu", new List<string> { "Privacy Policy", "Terms of Service", "Contact Us" } }
                }
            },
            { "ru", new Dictionary<string, List<string>>
                {
                    { "Header_Menu", new List<string> { "Главная", "Помощь", "О нас" } },
                    { "Footer_Menu", new List<string> { "Политика конфиденциальности", "Условия использования", "Связаться с нами" } }
                }
            },
            { "fr", new Dictionary<string, List<string>>
                {
                    { "Header_Menu", new List<string> { "Accueil", "Aide", "À propos" } },
                    { "Footer_Menu", new List<string> { "Politique de confidentialité", "Conditions d'utilisation", "Contactez-nous" } }
                }
            }
        };
    }
}
