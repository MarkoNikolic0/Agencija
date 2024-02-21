using FluentNHibernate.Mapping;
using Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Mapiranja;

class LicencaMapiranje:ClassMap<Licenca>
{
    public LicencaMapiranje()
    {
        Table("LICENCA");

        Id(x => x.Id, "ID");

        Map(x => x.BrojLicence, "BROJ_LICENCE");
        Map(x => x.Institucija, "INSTITUCIJA");
        Map(x => x.DatumSticanja, "DATUM_STICANJA");
    }
}
