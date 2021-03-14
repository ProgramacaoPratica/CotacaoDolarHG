using Newtonsoft.Json;

namespace CotacaoDolarHG
{
    public class Market
    {
        public Market()
        {
            this.Currency = new Currency();
        }

        [JsonProperty(PropertyName = "currencies")]
        public Currency Currency { get; set; }
    }
}
