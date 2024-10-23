using abstract_factory.Interfaces;
using abstract_factory.Models;

namespace abstract_factory.Products.Italian
{
    public class ItalianText : IText
    {
        public TextModel GetText()
        {
            return new TextModel()
            {
                Title = "Fabbrica astratta. Interfacce in diverse lingue",
                HeaderContext = new Dictionary<string, string> { { "Home", "Home" }, { "Help", "Aiuto" } },
                MainContext = new Dictionary<string, string> { { "Main", "Mosca\r\nMosca è la capitale della Russia e la città più grande del paese, un importante centro culturale. Qui, il passato si fonde con il presente, con antiche cattedrali che coesistono accanto a moderni grattacieli. Il Cremlino e la Piazza Rossa sono i simboli più noti di Mosca, visitati ogni anno da milioni di turisti. Altri luoghi imperdibili includono la Galleria Tretyakov, il famoso Teatro Bolshoi e il parco VDNH. Mosca offre un’esperienza indimenticabile per gli amanti della storia e dell'arte.\r\n\r\nSan Pietroburgo\r\nFondata da Pietro il Grande, San Pietroburgo è nota per i suoi palazzi, fiumi e canali. Spesso chiamata la \"Venezia del Nord\", la città incanta con la sua architettura e i suoi ponti mozzafiato. L'Hermitage, uno dei più grandi musei al mondo, ospita una collezione unica di opere d'arte. Non dimenticate di visitare la Fortezza di Pietro e Paolo, la Cattedrale di Sant'Isacco e di fare una passeggiata lungo la Prospettiva Nevskij.\r\n\r\nKazan\r\nKazan è una città dove Oriente e Occidente si incontrano. Capitale del Tatarstan, è nota per le sue moschee e le chiese ortodosse che convivono armoniosamente. Tra le principali attrazioni vi sono il Cremlino di Kazan, la Moschea di Qol Sharif e la via Bauman, famosa per lo shopping. Kazan è anche conosciuta per la sua deliziosa cucina tatara, come il chak-chak e il tradizionale echpochmak." } },
                FooterContext = new Dictionary<string, string> { { "Copyright", "Tutti i diritti riservati" }, { "Contacts", "Contatti: info@mail.ru" }, { "Address", "Indirizzo: Mosca, via Esempio, 123" } }
            };
        }
    }
}
