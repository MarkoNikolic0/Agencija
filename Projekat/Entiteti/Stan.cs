namespace Projekat.Entiteti;

public class Stan
{
    public virtual string Id { get; set; } = default!;

    public virtual int BrojStana { get; set; }

    public virtual int Povrsina { get; set; }

    public virtual Vlasnik VlasnikId { get; set; } = new();

    public virtual StambeniProstor StambeniProstorId { get; set; } = new();
}