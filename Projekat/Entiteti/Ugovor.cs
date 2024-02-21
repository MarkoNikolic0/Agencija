namespace Projekat.Entiteti;

public class Ugovor
{
    //TODO: izmeniti i u mapiranja i u bazu
    public virtual string Id { get; set; } = default!;

    public virtual string Sifra { get; set; } = default!;
    
    public virtual DateTime DatumPotpisivanja { get; set; }
    
    public virtual DateTime PeriodVazenja { get; set; }

    public virtual Zgrada ZgradaId { get; set; } = default!;
}
