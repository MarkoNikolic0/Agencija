using FluentNHibernate.Mapping;
using Projekat.Entiteti;
using Projekat.Extensions;

namespace Projekat.Mapiranja;

class ZgradaMapiranje:ClassMap<Zgrada>
{
    public ZgradaMapiranje() 
    {
        Table("ZGRADA");

        Id(x => x.Id, "ID");        

        Map(x => x.Adresa, "ADRESA");

        References(x => x.UpravnikId).Column("UPRAVNIK_ID").Cascade.All();//
        References(x => x.UgovorId).Column("UGOVOR_ID").Cascade.All();

        //proveriti ti za Inverse 
        HasMany(x => x.Ulazi).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
        HasMany(x=>x.Liftovi).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
  
    }
}
