namespace Projekat.Entiteti;

public class StambeniProstor
{
    public virtual string Id { get; set; } = default!;

    public virtual int BrojSprata { get; set; }

    public virtual Zgrada ZgradaId { get; set; } = default!;

    public virtual IList<Stan> Stanovi { get; set; } = new List<Stan>();

}
