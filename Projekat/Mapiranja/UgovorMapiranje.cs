using FluentNHibernate.Mapping;
using Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Mapiranja;

class UgovorMapiranje:ClassMap<Ugovor>
{
    public UgovorMapiranje()
    {
        Table("UGOVOR");

        Id(x => x.Id, "ID");
        
        Map(x => x.Sifra, "SIFRA");
        Map(x => x.DatumPotpisivanja).Column("DATUM_POTPISIVANJA");
        Map(x => x.PeriodVazenja).Column("PERIOD_VAZENJA");

        /*References(x => x.ZgradaId).Column("ZGRADA_ID");*/
    }
}
