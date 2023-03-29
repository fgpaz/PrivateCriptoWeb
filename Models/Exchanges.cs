using System.Text.Json.Serialization;

namespace Models;

public class ExchangeRates
{
    [JsonPropertyName("belo")] public CriptoBase? Belo { get; set; }
    [JsonPropertyName("letsbit")] public CriptoBase? Letsbit { get; set; }
    [JsonPropertyName("fiwind")] public CriptoBase? Fiwind { get; set; }
    [JsonPropertyName("lemoncash")] public CriptoBase? Lemoncash { get; set; }
    [JsonPropertyName("buenbit")] public CriptoBase? Buenbit { get; set; }
}