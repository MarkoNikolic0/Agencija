using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Entiteti;

public class Licenca
{
    public virtual string Id { get; set; } = default!;

    public virtual string BrojLicence { get; set; } = default!;

    public virtual string Institucija { get; set; } = default!;

    public virtual DateTime DatumSticanja { get; set; }

    public virtual Upravnik Upravnik { get; set; } = default!;
}
