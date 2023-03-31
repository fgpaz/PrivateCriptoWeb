using Microsoft.EntityFrameworkCore;
using Models.DAOs;

namespace DataAccess;

public class ExchangesDBAccess
{
    private readonly CriptoDbContext _context;

    public ExchangesDBAccess(CriptoDbContext context)
    {
        _context = context;
    }

    public async Task Create(ExchangeRateDAO? exchange)
    {
        await _context.ExchangeRates.AddAsync(exchange);
        _context.SaveChanges();
    }

    public async Task<ExchangeRateDAO?> Get(int id)
    {
        return await _context.ExchangeRates.FirstOrDefaultAsync(e=> e != null && e.Id == id);
    }

    public void Update(ExchangeRateDAO exchange)
    {
        _context.Update(exchange);
        _context.SaveChanges();
    }

    public void Delete(ExchangeRateDAO exchange)
    {
        _context.Remove(exchange);
        _context.SaveChanges();
    }
}