namespace Projekat.Entiteti;

public class Lokal
{
    public virtual string Id { get; set; } = default!;

    public virtual string ImeFirme { get; set; } = default!;

    public virtual PoslovniProstor ProstorId { get; set; } = default!;

}