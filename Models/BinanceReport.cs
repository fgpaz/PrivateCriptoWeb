using Newtonsoft.Json;

namespace Models;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
[JsonObject("adv")]
public class Data
{
    [JsonProperty("price")] public string? price { get; set; }

    [JsonProperty("tradeMethods")] public List<TradeMethod>? tradeMethods { get; set; }

    [JsonProperty("fiatSymbol")] public string? fiatSymbol { get; set; }

    [JsonProperty("dynamicMaxSingleTransAmount")] public string? dynamicMaxSingleTransAmount { get; set; }

    [JsonProperty("minSingleTransQuantity")] public string? minSingleTransQuantity { get; set; }

    [JsonProperty("maxSingleTransQuantity")] public string? maxSingleTransQuantity { get; set; }

    [JsonProperty("dynamicMaxSingleTransQuantity")] public string? dynamicMaxSingleTransQuantity { get; set; }

    [JsonProperty("tradableQuantity")] public string? tradableQuantity { get; set; }

    [JsonProperty("commissionRate")] public string? commissionRate { get; set; }
}

public class Trade
{
    [JsonProperty("adv")] public Data? Data { get; set; }
}

public class BinancePetition
{
    [JsonProperty("data")] public List<Trade>? data { get; set; }


    [JsonProperty("time")] public int time { get; set; }
}

public class TradeMethod
{
    [JsonProperty("identifier")] public string? identifier { get; set; }

    [JsonProperty("tradeMethodName")] public string? tradeMethodName { get; set; }
}