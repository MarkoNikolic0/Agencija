namespace Projekat.Entiteti;

public class ParkingMesto
{
    public virtual string Id { get; set; } = default!;

    public virtual string RegBroj { get; set; } = default!;

    public virtual Garaza GarazaId { get; set; } = default!;

}