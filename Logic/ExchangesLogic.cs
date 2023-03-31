using DataAccess;
using Models;

namespace Logic;

public class ExchangesLogic
{
    private readonly ExchangesAccess _exchangesAccess;

    public ExchangesLogic(ExchangesAccess exchangesAccess)
    {
        _exchangesAccess = exchangesAccess;
    }

    public async Task<List<CriptoBase>?> GetUSDT()
    {
        return null;
    }
}