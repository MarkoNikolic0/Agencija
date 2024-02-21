using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Entiteti;

public class Garaza
{
    public virtual string Id { get; set; } = default!;

    public virtual int RedniBroj { get; set; }

    public virtual Zgrada ZgradaId { get; set; } = default!;

    public virtual IList<ParkingMesto> ParkingMesta { get; set; } = new List<ParkingMesto>();
}
