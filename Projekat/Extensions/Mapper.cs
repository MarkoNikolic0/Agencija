using Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Projekat;

namespace Projekat.Extensions;

public static class Mapper
{

    public static List<ZgradaBasic> Map(this IEnumerable<Zgrada> zgrade)
    {
        List<ZgradaBasic> result = new();
        foreach(var zgrada in zgrade) 
        {
            result.Add(new ZgradaBasic
            {
                Adresa = zgrada.Adresa
            });
        }

        return result;
    }

    public static Ugovor Map(this UgovorBasic ugovor)
    {
        return new Ugovor
        {
            Id=GenerateId(),
            Sifra = ugovor.Sifra,
            PeriodVazenja = ugovor.PeriodVazenja,
            DatumPotpisivanja = DateTime.UtcNow
        };
    }  

    public static Zgrada Map(this ZgradaBasic zgrada, Ugovor ugovor, Upravnik upravnik)
    {
        return new Zgrada
        {
            Id=GenerateId(),
            Adresa = zgrada.Adresa,
            UgovorId = ugovor,
            UpravnikId = upravnik
        };
    }

    //public static List<StanPregled> MapPregled(this IEnumerable<Stan> stanovi)
    //{
    //    List<StanPregled> result = new();
    //    foreach (var stan in stanovi)
    //    {
    //        result.Add(new StanPregled
    //        {
    //            Id = stan.Id,
    //            BrojStana = stan.BrojStana,
    //            Povrsina = stan.Povrsina,
    //            Vlasnik = stan.VlasnikId,
    //            StambeniProstor = stan.StambeniProstorId
    //        });
    //    }

    //    return result;
    //}

    public static Zgrada Map(this ZgradaBasic zgrada)
    {
        return new Zgrada
        {
            Id = GenerateId(),
            Adresa = zgrada.Adresa,
            UgovorId=null,
            UpravnikId=null            
        };
    }
    public static ZgradaPregled Map1(this Zgrada zgrada)
    {
        return new ZgradaPregled
        {
            Adresa=zgrada.Adresa,           
            Ugovor=zgrada.UgovorId,
            Upravnik=zgrada.UpravnikId            
        };
    }


    public static Licenca Map(this LicencaBasic licenca)
    {
        return new Licenca
        {
            Id = GenerateId(),
            BrojLicence = licenca.BrojLicence,
            Institucija = licenca.Institucija,
            DatumSticanja = DateTime.UtcNow
        };
    }

    public static Upravnik Map(this UpravnikBasic upravnik) 
    {
        return new Upravnik
        {
            Id = GenerateId(),
            JMBG = upravnik.JMBG,
            Ime = upravnik.Ime,
            ImeRoditelja = upravnik.ImeRoditelja,
            Prezime = upravnik.Prezime,
            DatumRodjenja = upravnik.DatumRodjenja,
            BrojLk = upravnik.BrojLk,
            MestoIzdavanja = upravnik.MestoIzdavanja,
            BrTel = upravnik.BrTel,
            Adresa = upravnik.Adresa,
            Institucija = upravnik.Institucija,
            Zvanje = upravnik.Zvanje,
            DatumSticanja = upravnik.DatumSticanja
        };
    }

    public static UpravnikPregled Map1(this Upravnik upravnik)
    {
        return new UpravnikPregled
        {
            Id = upravnik.Id,
            JMBG = upravnik.JMBG,
            Ime = upravnik.Ime,
            ImeRoditelja = upravnik.ImeRoditelja,
            Prezime = upravnik.Prezime,
            DatumRodjenja = upravnik.DatumRodjenja,
            BrojLk = upravnik.BrojLk,
            MestoIzdavanja = upravnik.MestoIzdavanja,
            BrTel = upravnik.BrTel,
            Adresa = upravnik.Adresa,
            Institucija = upravnik.Institucija,
            Zvanje = upravnik.Zvanje,
            DatumSticanja = upravnik.DatumSticanja
        };
    }

    public static UpravnikBasic Map2(this UpravnikPregled upravnik)
    {
        return new UpravnikBasic
        {
            Id = upravnik.Id,
            JMBG = upravnik.JMBG,
            Ime = upravnik.Ime,
            ImeRoditelja = upravnik.ImeRoditelja,
            Prezime = upravnik.Prezime,
            DatumRodjenja = upravnik.DatumRodjenja,
            BrojLk = upravnik.BrojLk,
            MestoIzdavanja = upravnik.MestoIzdavanja,
            BrTel = upravnik.BrTel,
            Adresa = upravnik.Adresa,
            Institucija = upravnik.Institucija,
            Zvanje = upravnik.Zvanje,
            DatumSticanja = upravnik.DatumSticanja
        };
    }

    public static Ulaz Map(this UlaziBasic ulaz)
    {
        return new Ulaz
        {
            Id = GenerateId(),
            RedniBroj = ulaz.RedniBroj,
            Kamera = ulaz.Kamera,
            Otvoren = ulaz.Otvoren
        };
    }

    public static Lift Map(this LiftBasic lift) 
    {
        return new Lift
        {
            Id = GenerateId(),
            SerijskiBroj = lift.SerijskiBroj,
            Proizvodjac = lift.Proizvodjac,
            DatumKvara = lift.DatumKvara,
            DatumServisiranja = lift.DatumServisiranja,
            DaniVanUpotrebe = (int)(lift.DatumServisiranja-lift.DatumKvara).TotalDays,            
            BrojOsoba = lift.BrojOsoba,
            Nosivost = lift.Nosivost,
            Tip = lift.Tip
        };
    }

    //public static Garaza Map(this GarazaBasic garaza) 
    //{
    //    return new Garaza
    //    {
    //        Id = GenerateId(),
    //        RedniBroj = garaza.RedniBroj
    //    };
    //}
    public static StambeniProstor Map(this StambeniProstorBasic stambeniProstor)
    {
        return new StambeniProstor
        {
            Id = GenerateId(),
            BrojSprata=stambeniProstor.BrojSprata
        };
    }

    public static StambeniProstorPregled Map1(this StambeniProstor stambeniProstor)
    {
        return new StambeniProstorPregled
        {
            BrojSprata = stambeniProstor.BrojSprata,
            Zgrada=stambeniProstor.ZgradaId
        };
    }

    public static Garaza Map(this GarazaBasic garaza)
    {
        return new Garaza
        {
            Id = GenerateId(),
            RedniBroj=garaza.RedniBroj
        };
    }

    public static PoslovniProstor Map(this PoslovniProstorBasic poslovniProstor)
    {
        return new PoslovniProstor
        {
            Id = GenerateId(),
            RedniBroj=poslovniProstor.RedniBroj
        };
    }

    //public static ParkingMesto Map(this ParkingMestoBasic parkingMesto)
    //{
    //    return new ParkingMesto
    //    {
    //        Id = GenerateId(),
    //        RegBroj = parkingMesto.RegBroj
    //    };
    //}

    public static Lokal Map(this LokalBasic lokal)
    {
        return new Lokal
        {
            Id = GenerateId(),
            ImeFirme = lokal.ImeFirme
        };
    }

    public static Stan Map(this StanBasic stan) 
    {
        return new Stan
        {
            Id= GenerateId(),
            BrojStana=stan.BrojStana,
            Povrsina=stan.Povrsina,
            VlasnikId=null
        };
    }
    public static VlasnikPregled Map1(this Vlasnik vlasnik)
    {
        return new VlasnikPregled
        {
            JMBG = vlasnik.JMBG,
            Ime = vlasnik.Ime,
            ImeRoditelja = vlasnik.ImeRoditelja,
            Prezime = vlasnik.Prezime,
            BrojTelefona = vlasnik.BrojTelefona,
            Adresa = vlasnik.Adresa,
            Funkcija = vlasnik.Funkcija           
        };
    }
    public static Vlasnik Map2(this VlasnikBasic vlasnik)
    {
        return new Vlasnik
        {
            Id = GenerateId(),
            JMBG = vlasnik.JMBG,
            Ime = vlasnik.Ime,
            ImeRoditelja = vlasnik.ImeRoditelja,
            Prezime = vlasnik.Prezime,
            BrojTelefona = vlasnik.BrojTelefona,
            Adresa = vlasnik.Adresa,
            Funkcija = vlasnik.Funkcija
        };
    }

    public static string GenerateId()
    {
        var randomNumber = new byte[20];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }
}
