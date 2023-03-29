using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Models;

public class CriptoBase
{
    [System.Text.Json.Serialization.JsonConstructor]
    public CriptoBase()
    {
    }

    public CriptoBase(CriptoBase criptoBase, string exchange)
    {
        comprar_USDT = criptoBase.comprar_USDT;
        vender_USDT = criptoBase.vender_USDT;
        fecha = criptoBase.fecha;
        this.exchange = exchange;
    }

    [JsonProperty("totalAsk")] public double comprar_USDT { get; set; }
    // [JsonProperty("totalAsk")] public double comprar_USDTs { get; set; }
    [JsonProperty("totalBid")] public double vender_USDT { get; set; }
    [JsonProperty("time")] public long time { get; set; }

    public DateTime fecha
    {
        get => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local).AddSeconds(time).AddHours(-3);
        set { }
    }

    public string? exchange { get; set; }
}