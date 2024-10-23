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
                HeaderContext = new Dictionary<string, string> { { "Home", "Home" }, { "Help", "Aiuto" } },
                MainContext = new Dictionary<string, string> { { "Main", "Benvenuti sul nostro sito! Siamo lieti di offrirvi una vasta gamma di servizi progettati per migliorare la vostra esperienza nel campo delle tecnologie dell'informazione. Il nostro team di professionisti è pronto ad assistervi nella realizzazione di progetti digitali e innovativi.\r\n\r\nCi impegniamo a fornire servizi di alta qualità, affidabili e conformi agli standard più elevati. Indipendentemente dalla complessità del vostro progetto, garantiamo un approccio personalizzato e un'esecuzione efficiente nei tempi previsti.\r\n\r\nContattateci per saperne di più sui nostri prodotti e servizi. Siamo sempre disponibili per rispondere alle vostre domande e aiutarvi a scegliere la soluzione ottimale per la vostra azienda." } }
            };
        }
    }
}
