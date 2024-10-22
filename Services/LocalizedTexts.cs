namespace abstract_factory.Services
{
    public class LocalizedTexts
    {
        public static readonly Dictionary<string, Dictionary<string, List<string>>> Translations = new()
        {
            { "ru", new Dictionary<string, List<string>>
                {
                    { "HeaderContent", new List<string, string> { { "Home", "Главная" }, { "Help", "Помощь" } } },
                    { "MainContent", new List<string> { { "MainText", "Добро пожаловать на наш сайт! Мы рады предложить вам широкий спектр услуг, направленных на улучшение вашего опыта в сфере информационных технологий. Наша команда профессионалов готова помочь вам в решении любых задач, связанных с цифровыми решениями и инновациями.\r\n\r\nМы стремимся к тому, чтобы предоставлять качественные и надежные услуги, которые соответствуют самым высоким стандартам. Независимо от сложности вашего проекта, мы обеспечим индивидуальный подход и эффективное выполнение задач в срок.\r\n\r\nСвяжитесь с нами, чтобы узнать больше о наших продуктах и услугах. Мы всегда готовы ответить на ваши вопросы и помочь вам выбрать оптимальное решение для вашего бизнеса.\r\n\r\n" } } },
                    { "FooterContent", new List<string> { { "Copyright", "22.10.2024. Все права защищены" }, { "Contacts", "Контакты: info@mysite.com" }, { "Address", "Адрес: г. Москва, ул. Примерная, д. 123" } } }
                }
            },
            { "fr", new Dictionary<string, List<string>>
                {
                    { "HeaderContent", new List<string, string> { { "Home", "Accueil" }, { "Help", "Aide" } } },
                    { "MainContent", new List<string> { { "MainText", "Bienvenue sur notre site ! Nous sommes ravis de vous offrir une large gamme de services conçus pour améliorer votre expérience dans le domaine des technologies de l'information. Notre équipe de professionnels est prête à vous accompagner dans la réalisation de vos projets numériques et innovants.\r\n\r\nNous nous efforçons de fournir des services de haute qualité, fiables et conformes aux normes les plus strictes. Quel que soit le niveau de complexité de votre projet, nous garantissons une approche personnalisée et une exécution efficace dans les délais impartis.\r\n\r\nContactez-nous pour en savoir plus sur nos produits et services. Nous sommes toujours disponibles pour répondre à vos questions et vous aider à choisir la solution optimale pour votre entreprise." } } },
                    { "FooterContent", new List<string> { { "Copyright", "22.10.2024. Tous droits réservés" }, { "Contacts", "Contacts: info@mysite.com" }, { "Address", "Adresse : Moscou, rue Exemple, bâtiment 123" } } }
                }
            },
            { "it", new Dictionary<string, List<string>>
                {
                    { "HeaderContent", new List<string, string> { { "Home", "Home" }, { "Help", "Aiuto" } } },
                    { "MainContent", new List<string> { { "MainText", "Benvenuti sul nostro sito! Siamo lieti di offrirvi una vasta gamma di servizi progettati per migliorare la vostra esperienza nel campo delle tecnologie dell'informazione. Il nostro team di professionisti è pronto ad assistervi nella realizzazione di progetti digitali e innovativi.\r\n\r\nCi impegniamo a fornire servizi di alta qualità, affidabili e conformi agli standard più elevati. Indipendentemente dalla complessità del vostro progetto, garantiamo un approccio personalizzato e un'esecuzione efficiente nei tempi previsti.\r\n\r\nContattateci per saperne di più sui nostri prodotti e servizi. Siamo sempre disponibili per rispondere alle vostre domande e aiutarvi a scegliere la soluzione ottimale per la vostra azienda." } } },
                    { "FooterContent", new List<string> { { "Copyright", "22.10.2024. Tutti i diritti riservati" }, { "Contacts", "Contatti: info@mysite.com" }, { "Address", "Indirizzo: Mosca, via Esempio, 123" } } }
                }
            }
        };
    }
}
