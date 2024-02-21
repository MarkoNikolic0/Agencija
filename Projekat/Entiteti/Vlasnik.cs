namespace Projekat.Entiteti;

public class Vlasnik
{
    public virtual string Id { get; set; } = default!;

    public virtual string JMBG { get; set; } = default!;

    public virtual string Ime { get; set; } = default!;

    public virtual string ImeRoditelja { get; set; } = default!;

    public virtual string Prezime { get; set; } = default!;

    public virtual string BrojTelefona { get; set; }=default!;

    public virtual string Adresa { get; set; } = default!;

    public virtual string Funkcija { get; set; } = default!;

    public virtual IList<Stan> Stanovi { get; set; } = new List<Stan>();
}