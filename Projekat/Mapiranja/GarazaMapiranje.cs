using FluentNHibernate.Mapping;
using Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Mapiranja;

class GarazaMapiranje:ClassMap<Garaza>
{
    public GarazaMapiranje()
    {
        Table("GARAZA");

        Id(x => x.Id, "ID");
    
        Map(x => x.RedniBroj, "REDNI_BROJ");

        References(x => x.ZgradaId).Column("ZGRADA_ID");

        HasMany(x => x.ParkingMesta).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
    }
}
