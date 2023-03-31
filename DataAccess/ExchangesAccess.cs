using Models;

namespace DataAccess;

public sealed class ExchangesAccess : WebAccess
{
    private List<CriptoBase>? exchanges;

    public ExchangesAccess(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("CriptoYaExchanges");
    }

    public async Task<List<CriptoBase>?> GetUSDTExchanges()
    {
        var resultado = await Get<ExchangeRates>("");
        resultado!.Belo!.exchange = "Belo";
        resultado.Buenbit!.exchange = "Buenbit";
        resultado.Fiwind!.exchange = "Fiwind";
        resultado.Letsbit!.exchange = "Letsbit";
        resultado.Lemon!.exchange = "Lemon";
        exchanges = new List<CriptoBase>
        {
            resultado.Belo,
            resultado.Lemon,
            resultado.Buenbit,
            resultado.Fiwind,
            resultado.Letsbit
        };
        exchanges = exchanges.OrderByDescending(e => e.vender_USDT).ToList();
        return exchanges;
    }
}