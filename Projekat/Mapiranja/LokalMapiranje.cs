using FluentNHibernate.Mapping;
using Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Mapiranja;

class LokalMapiranje:ClassMap<Lokal>
{
    public LokalMapiranje()
    {
        Table("LOKAL");

        Id(x => x.Id, "ID");

        Map(x => x.ImeFirme, "IME_FIRME");

        References(x => x.ProstorId).Column("PROSTOR_ID");       
    }
}
