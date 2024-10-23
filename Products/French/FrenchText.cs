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
                MainContext = new Dictionary<string, string> { { "Main", "Moscou\r\nMoscou est la capitale de la Russie et la plus grande ville du pays. C'est un centre culturel important où l'histoire rencontre la modernité. Le Kremlin et la Place Rouge sont les symboles emblématiques de Moscou, attirant des millions de visiteurs chaque année. Parmi les autres incontournables figurent la galerie Tretiakov, le célèbre Théâtre Bolchoï et le parc VDNH. Que vous soyez passionné par l'art ou l'histoire, Moscou a quelque chose à offrir à chacun.\r\n\r\nSaint-Pétersbourg\r\nFondée par Pierre le Grand, Saint-Pétersbourg est célèbre pour ses palais, ses rivières et ses canaux. Surnommée souvent la \"Venise du Nord\", cette ville enchante par son architecture impressionnante et ses ponts majestueux. Le musée de l’Ermitage, l'un des plus grands du monde, abrite une collection unique d'œuvres d'art. Ne manquez pas non plus la forteresse Pierre-et-Paul, la cathédrale Saint-Isaac et une promenade sur la perspective Nevski.\r\n\r\nKazan\r\nKazan est une ville où se rencontrent l'Orient et l'Occident. Capitale du Tatarstan, elle est connue pour ses mosquées élégantes et ses églises orthodoxes coexistant harmonieusement. Les sites principaux incluent le Kremlin de Kazan, la mosquée Qol Sharif et la rue piétonne Bauman. Kazan est également réputée pour sa cuisine délicieuse, notamment le chak-chak et les triangles de pâte fourrés, l'echpochmak." } },
                FooterContext = new Dictionary<string, string> { { "Copyright", "Tous droits réservés" }, { "Contacts", "Contacts: info@mail.ru" }, { "Address", "Adresse : Moscou, rue Exemple, bâtiment 123" } }
            };
        }
    }
}
