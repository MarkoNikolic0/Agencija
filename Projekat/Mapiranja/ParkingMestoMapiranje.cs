using FluentNHibernate.Mapping;
using Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Mapiranja;

class ParkingMestoMapiranje:ClassMap<ParkingMesto>
{
    public ParkingMestoMapiranje()
    {
        Table("PARKING_MESTO");

        Id(x => x.Id, "ID");

        Map(x => x.RegBroj, "REG_BROJ");      

        References(x => x.GarazaId, "GARAZA_ID");
    }
}
