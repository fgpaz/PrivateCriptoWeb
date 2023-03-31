using Newtonsoft.Json;

namespace Models;

public class CriptoBase
{
    [System.Text.Json.Serialization.JsonConstructor]
    public CriptoBase()
    {
    }
    

    [JsonProperty("totalAsk")] public double comprar_USDT { get; set; }
    
    [JsonProperty("totalBid")] public double vender_USDT { get; set; }
    [JsonProperty("time")] public long time { get; set; }

    public DateTime fecha
    {
        get => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local).AddSeconds(time).AddHours(-3);
        set { }
    }

    public string? exchange { get; set; }
}