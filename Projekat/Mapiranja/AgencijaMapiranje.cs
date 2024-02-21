using FluentNHibernate.Mapping;
using Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Mapiranja;

class AgencijaMapiranje:ClassMap<Agencija>
{
    public AgencijaMapiranje ()
    {
        Table("AGENCIJA");

        Id(x=>x.Id,"ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Ime, "IME");

        HasMany(x => x.Zgrade).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.Upravnici).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
    }
}
