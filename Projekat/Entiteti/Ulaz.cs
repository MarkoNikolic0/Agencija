using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Entiteti;

public class Ulaz
{
    public virtual string Id { get; set; } = default!;

    public virtual Zgrada ZgradaId { get; set; } = new();

    public virtual int RedniBroj { get; set; }

    public virtual string Otvoren { get; set; } = default!;

    public virtual int Kamera { get; set; }

}
