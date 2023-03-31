namespace Models.DAOs;

public class CriptoBaseDAO
{
    public int Id { get; set; }

    public double ComprarUsdt { get; set; }

    public double VenderUsdt { get; set; }

    public DateTime Fecha { get; set; }

    public string? Exchange { get; set; }

    public IEnumerable<ExchangeRateDAO> ExchangeRateBelos { get; } = new List<ExchangeRateDAO>();

    public IEnumerable<ExchangeRateDAO> ExchangeRateBuenbits { get; } = new List<ExchangeRateDAO>();

    public IEnumerable<ExchangeRateDAO> ExchangeRateFiwinds { get; } = new List<ExchangeRateDAO>();

    public IEnumerable<ExchangeRateDAO> ExchangeRateLemons { get; } = new List<ExchangeRateDAO>();

    public IEnumerable<ExchangeRateDAO> ExchangeRateLetsbits { get; } = new List<ExchangeRateDAO>();
}