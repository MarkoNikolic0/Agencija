namespace Projekat.Entiteti;

public class Lift
{
    public virtual string Id { get; set; } = default!;

    public virtual string SerijskiBroj { get; set; } = default!;

    public virtual Zgrada ZgradaId { get; set; } = default!;
    
    public virtual string Proizvodjac { get; set; } = default!;
    
    public virtual DateTime? DatumServisiranja { get; set; }
    
    public virtual DateTime? DatumKvara { get; set; }
    
    public virtual int DaniVanUpotrebe { get; set; }
    
    public virtual string Tip { get; set; } = default!;
    
    public virtual int Nosivost { get; set; }
    
    public virtual int BrojOsoba { get; set; }

}