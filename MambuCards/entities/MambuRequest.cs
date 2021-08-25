using System;
namespace MambuCards.entities
{
    public class MambuRequest
    {
        public string USER_KEY { get; set; }

        public string ALGORITHM { get; set; }

        public string TENANT_ID { get; set; }

        public string DOMAIN { get; set; }

        public string OBJECT_ID { get; set; }
    }
}
