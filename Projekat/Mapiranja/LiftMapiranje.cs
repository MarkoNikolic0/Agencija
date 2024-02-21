using FluentNHibernate.Mapping;
using Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Mapiranja;

class LiftMapiranje:ClassMap<Lift>
{

    public LiftMapiranje() 
    {
        Table("LIFT");

        Id(x => x.Id, "ID");

        Map(x => x.SerijskiBroj, "SERIJSKI_BROJ");
        Map(x => x.Proizvodjac, "PROIZVODJAC");
        Map(x => x.DatumServisiranja, "DATUM_SERVISIRANJA");
        Map(x => x.DatumKvara, "DATUM_KVARA");
        Map(x => x.DaniVanUpotrebe, "DANI_VAN_UPOTREBE");
        Map(x => x.Tip, "TIP");
        Map(x => x.Nosivost, "NOSIVOST");
        Map(x => x.BrojOsoba, "BROJ_OSOBA");

        References(x => x.ZgradaId).Column("ZGRADA_ID");
    }
}
