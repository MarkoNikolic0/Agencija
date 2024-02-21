using FluentNHibernate.Mapping;
using Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Mapiranja;

class StanMapiranje:ClassMap<Stan>
{
    public StanMapiranje() 
    {
        Table("STAN");

        Id(x => x.Id, "ID");

        Map(x => x.BrojStana, "BROJ_STANA");
        Map(x => x.Povrsina, "POVRSINA");

        References(x => x.VlasnikId).Column("VLASNIK_ID");
        References(x => x.StambeniProstorId).Column("PROSTOR_ID");
    }
}
