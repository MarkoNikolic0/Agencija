using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Mapiranja;

class UlazMapiranje:ClassMap<Ulaz>
{
    public UlazMapiranje() 
    {
        Table("ULAZ");

        Id(x => x.Id, "ID");

        Map(x => x.RedniBroj, "REDNI_BROJ");
        Map(x => x.Kamera, "KAMERA");
        Map(x => x.Otvoren, "OTVOREN");

        References(x => x.ZgradaId).Column("ZGRADA_ID");

    }
}
