using FluentNHibernate.Mapping;
using Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Mapiranja;

class PoslovniProstorMapiranje:ClassMap<PoslovniProstor>
{
    public PoslovniProstorMapiranje()
    {
        Table("POSLOVNI_PROSTOR");

        Id(x => x.Id, "ID");

        Map(x => x.RedniBroj, "REDNI_BROJ");
        
        References(x => x.ZgradaId, "ZGRADA_ID");

        HasMany(x => x.Lokali).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
    }
}
