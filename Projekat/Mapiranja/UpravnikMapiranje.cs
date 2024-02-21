using FluentNHibernate.Mapping;
using Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Mapiranja;

class UpravnikMapiranje:ClassMap<Upravnik>
{
    public UpravnikMapiranje() 
    {
        Table("UPRAVNIK");

        Id(x => x.Id, "ID");

        Map(x => x.JMBG, "JMBG");
        Map(x => x.Ime, "IME");
        Map(x => x.ImeRoditelja, "IME_RODITELJA");
        Map(x => x.Prezime, "PREZIME");
        Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
        Map(x => x.BrojLk, "BROJ_LICNE_KARTE");
        Map(x => x.MestoIzdavanja, "MESTO_IZDAVANJA");
        Map(x => x.BrTel, "BROJ_TELEFONA");
        Map(x => x.Adresa, "ADRESA");

        Map(x => x.Institucija, "INSTITUCIJA");
        Map(x => x.Zvanje, "ZVANJE");
        Map(x => x.DatumSticanja, "DATUM_STICANJA");

        References(x => x.LicencaId).Column("LICENCA_ID");

        HasMany(x => x.Zgrade).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
    }
}
