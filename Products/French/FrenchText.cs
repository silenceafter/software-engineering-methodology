using abstract_factory.Interfaces;
using abstract_factory.Models;

namespace abstract_factory.Products.French
{
    public class FrenchText : IText
    {
        public TextModel GetText()
        {
            return new TextModel()
            {
                HeaderContext = new Dictionary<string, string> { { "Home", "Accueil" }, { "Help", "Aide" } },
                MainContext = new Dictionary<string, string> { { "Main", "Bienvenue sur notre site ! Nous sommes ravis de vous offrir une large gamme de services conçus pour améliorer votre expérience dans le domaine des technologies de l'information. Notre équipe de professionnels est prête à vous accompagner dans la réalisation de vos projets numériques et innovants.\r\n\r\nNous nous efforçons de fournir des services de haute qualité, fiables et conformes aux normes les plus strictes. Quel que soit le niveau de complexité de votre projet, nous garantissons une approche personnalisée et une exécution efficace dans les délais impartis.\r\n\r\nContactez-nous pour en savoir plus sur nos produits et services. Nous sommes toujours disponibles pour répondre à vos questions et vous aider à choisir la solution optimale pour votre entreprise." } }
            };
        }
    }
}
