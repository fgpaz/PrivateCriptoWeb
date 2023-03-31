namespace Models.DAOs;

public class ExchangeRateDAO
{
    public int Id { get; set; }

    public int? BeloId { get; set; }

    public int? LetsbitId { get; set; }

    public int? FiwindId { get; set; }

    public int? LemonId { get; set; }

    public int? BuenbitId { get; set; }

    public CriptoBaseDAO? Belo { get; set; }

    public CriptoBaseDAO? Buenbit { get; set; }

    public CriptoBaseDAO? Fiwind { get; set; }

    public CriptoBaseDAO? Lemon { get; set; }

    public CriptoBaseDAO? Letsbit { get; set; }
}