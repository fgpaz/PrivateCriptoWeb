using Newtonsoft.Json;

namespace Models;

public class ExchangeRates
{
    [JsonProperty("belo")] public CriptoBase? Belo { get; set; }
    [JsonProperty("letsbit")] public CriptoBase? Letsbit { get; set; }
    [JsonProperty("fiwind")] public CriptoBase? Fiwind { get; set; }
    [JsonProperty("lemoncash")] public CriptoBase? Lemon { get; set; }
    [JsonProperty("buenbit")] public CriptoBase? Buenbit { get; set; }
}