using FluentNHibernate.Mapping;
using Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Mapiranja;

class VlasnikMapiranje:ClassMap<Vlasnik>
{
    public VlasnikMapiranje() 
    {
        Table("VLASNIK");

        Id(x => x.Id, "ID");

        Map(x => x.JMBG, "JMBG");
        Map(x => x.Ime, "IME");
        Map(x => x.ImeRoditelja, "IME_RODITELJA");
        Map(x => x.Prezime, "PREZIME");
        Map(x => x.BrojTelefona, "BROJ_TELEFONA");
        Map(x => x.Adresa, "ADRESA");
        Map(x => x.Funkcija, "FUNKCIJA");
        
        HasMany(x=>x.Stanovi).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
    }
}
