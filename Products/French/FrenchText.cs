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
                Title = "Fabrique abstraite. Interfaces dans différentes langues",
                HeaderContext = new Dictionary<string, string> { { "Home", "Accueil" }, { "Help", "Aide" } },
                MainContext = new Dictionary<string, string> { { "Main", "Paris : La Ville Lumière Paris, capitale de la France, est un véritable joyau du patrimoine culturel et artistique mondial. Avec ses monuments emblématiques comme la Tour Eiffel, le Louvre et la Cathédrale Notre-Dame, Paris attire des millions de visiteurs chaque année. Se promener le long des Champs-Élysées, flâner dans les quartiers pittoresques de Montmartre, ou découvrir l'histoire fascinante du Musée d'Orsay ne sont que quelques-unes des innombrables activités à faire dans cette ville magique. Paris, c'est aussi l'élégance de ses cafés et de sa gastronomie, offrant une expérience unique aux amateurs de culture et de cuisine.\r\n\r\nLyon : Le Cœur Gastronomique de la France Située entre Paris et Marseille, Lyon est connue pour être la capitale gastronomique de la France. Ville historique, classée au patrimoine mondial de l'UNESCO, elle séduit par ses traboules mystérieuses, ses fresques murales et ses quartiers riches en histoire. Flâner dans le Vieux Lyon, explorer les pentes de la Croix-Rousse ou savourer une délicieuse quenelle dans un bouchon lyonnais sont des moments incontournables pour tout visiteur. Lyon, c'est aussi un lieu de culture et de festivités, avec des événements célèbres comme la Fête des Lumières.\r\n\r\nMarseille : Entre Mer et Montagnes Située sur la côte méditerranéenne, Marseille est une ville dynamique et multiculturelle, où les influences du sud de la France se mêlent à celles de la Méditerranée. Son Vieux-Port pittoresque, dominé par la majestueuse Basilique Notre-Dame de la Garde, offre une vue imprenable sur la mer et les îles du Frioul. Les amateurs de nature apprécieront les Calanques, des criques sauvages où l'eau cristalline invite à la baignade et à l'exploration. Marseille, avec son ambiance chaleureuse et sa cuisine aux accents provençaux, est une destination idéale pour ceux qui souhaitent allier aventure, détente et découvertes culturelles." } },
                FooterContext = new Dictionary<string, string> { { "Copyright", "Tous droits réservés" }, { "Contacts", "Contacts: info@mail.ru" }, { "Address", "Adresse : Moscou, rue Exemple, bâtiment 123" } }
            };
        }
    }
}
