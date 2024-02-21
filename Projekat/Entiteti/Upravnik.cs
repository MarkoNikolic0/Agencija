namespace Projekat.Entiteti;

public class Upravnik
{
    public virtual string Id { get; set; } = default!;

    public virtual string JMBG { get; set; } = default!;

    public virtual string Ime { get; set; } = default!;

    public virtual string ImeRoditelja { get; set; } = default!;

    public virtual string Prezime { get; set; } = default!;

    public virtual DateTime DatumRodjenja { get; set; }

    public virtual string BrojLk { get; set; } = default!;

    public virtual string MestoIzdavanja { get; set; } = default!;

    public virtual string BrTel { get; set; } = default!;

    public virtual string Adresa { get; set; } = default!;

    public virtual string Institucija { get; set; } = default!;

    public virtual string Zvanje { get; set; } = default!;

    public virtual DateTime DatumSticanja { get; set; } = default!;

    public virtual Licenca LicencaId { get; set; } = default!;

    public virtual IList<Zgrada> Zgrade { get; set; } = new List<Zgrada>();
}