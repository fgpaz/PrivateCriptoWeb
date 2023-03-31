using Microsoft.EntityFrameworkCore;
using Models;
using Models.DAOs;

namespace DataAccess;

public class CriptoBaseDBAccess
{
    private readonly CriptoDbContext _context;

    public CriptoBaseDBAccess(CriptoDbContext context)
    {
        _context = context;
    }

    public async Task Create(CriptoBase? criptoBase)
    {
        await _context.CriptoBases.AddAsync(criptoBase);
        await _context.SaveChangesAsync();
    }

    public async Task<CriptoBase?> Get(string exchange)
    {
        return await _context.CriptoBases.FirstOrDefaultAsync(e=> e.exchange == exchange);
    }

    public void Update(CriptoBase c)
    {
        _context.CriptoBases.Update(c);
        _context.SaveChanges();
    }

    public void Delete(CriptoBase c)
    {
        _context.CriptoBases.Remove(c);
        _context.SaveChanges();
    }
}