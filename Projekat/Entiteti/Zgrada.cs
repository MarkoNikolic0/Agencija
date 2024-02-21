using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Entiteti;

public class Zgrada
{
    public virtual string Id { get; set; } = default!;

    public virtual string Adresa { get; set; } = default!;

    public virtual Upravnik UpravnikId { get; set; } = new();

    public virtual Ugovor UgovorId { get; set; } = new();

    public virtual IList<Ulaz> Ulazi { get; set; } = new List<Ulaz>();

    public virtual IList<Lift> Liftovi { get; set; } = new List<Lift>(); 
}
