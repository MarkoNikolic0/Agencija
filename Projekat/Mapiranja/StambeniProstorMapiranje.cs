using FluentNHibernate.Mapping;
using Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Mapiranja;

 class StambeniProstorMapiranje:ClassMap<StambeniProstor>
{
    public StambeniProstorMapiranje()
    {
        Table("STAMBENI_PROSTOR");

        Id(x => x.Id, "ID");

        Map(x => x.BrojSprata, "BROJ_SPRATA");

        References(x => x.ZgradaId, "ZGRADA_ID");
        
        HasMany(x=>x.Stanovi).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();

    }

}
