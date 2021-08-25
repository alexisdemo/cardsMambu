using System;
namespace MambuCards.entities
{
    public class Card
    {
        public Card()
        {
        }

        public string cardToken { get; set; }
        public string externalReferenceId { get; set; }
        public string advice { get; set; }
        public string amount { get; set; }
        public string status { get; set; }
        public string creditDebitIndicator { get; set; }
        public string encodedKey { get; set; }
    }
}
