using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Entiteti;

public class Agencija
{
    public virtual string Id { get; protected set; } = default!;

    public virtual string Ime { get; set; } = default!;

    public virtual IList<Zgrada> Zgrade { get; set;}=new List<Zgrada>();
    public virtual IList<Upravnik> Upravnici { get; set; } = new List<Upravnik>();

}
