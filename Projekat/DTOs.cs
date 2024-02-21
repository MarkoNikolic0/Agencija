using Projekat.Entiteti;
using System.Linq.Expressions;
using System.Text.Json.Serialization;

namespace Projekat;

#region Zgrada
public class ZgradaBasic
{
    public string Id { get; set; } = default!;
    public string Adresa { get; set; } = default!;
    public UpravnikBasic Upravnik = default!;
    public UgovorBasic Ugovor = default!;
}

public class ZgradaPregled
{
    public string Id { get; set; } = default!;
    public string Adresa { get; set; } = default!;
    public Upravnik Upravnik = default!;
    public Ugovor Ugovor = default!;

}

#endregion

#region Agencija

public class AgencijaBasic
{
    public string Id { get; set; } = default!;
    public string Ime { get; set; } = default!;

    public virtual IList<ZgradaBasic> Zgrade { get; set; }
    public virtual IList<UpravnikBasic> Upravnici { get; set; }

    public AgencijaBasic()
    {
        Zgrade = new List<ZgradaBasic>();
        Upravnici = new List<UpravnikBasic>();
    }

    public AgencijaBasic(string id, string ime)
    {
        this.Id = id;
        this.Ime = ime;
    }
}

public class AgencijaPregled
{
    public string Id { get; set; } = default!;
    public string Ime { get; set; } = default!;

    public AgencijaPregled() { }

    public AgencijaPregled(string id, string ime)
    {
        this.Id = id;
        this.Ime = ime;
    }
}

#endregion

/*#region Zaposleni
public class ZaposleniBasic
{
    public int Id { get; set; }
    public int JMBG { get; set; }
    public string Ime { get; set; } = default!;
    public string ImeRoditelja { get; set; } = default!;
    public string Prezime { get; set; } = default!;
    public DateTime DatumRodjenja { get; set; }
    public int BrojLk { get; set; }
    public string MestoIzdavanja { get; set; } = default!;
    public int BrTel { get; set; }
    public string Adresa { get; set; } = default!;
}

public class ZaposleniPregled
{
    public int Id { get; set; }
    public int JMBG { get; set; }
    public string Ime { get; set; } = default!;
    public string ImeRoditelja { get; set; } = default!;
    public string Prezime { get; set; } = default!;
    public DateTime DatumRodjenja { get; set; }
    public int BrojLk { get; set; }
    public string MestoIzdavanja { get; set; } = default!;
    public int BrTel { get; set; }
    public string Adresa { get; set; } = default!;
}
#endregion*/

#region Upravnik
public class UpravnikBasic
{
    public virtual string Id { get; set; }

    public virtual string JMBG { get; set; } = default!;

    public virtual string Ime { get; set; } = default!;

    public virtual string ImeRoditelja { get; set; } = default!;

    public virtual string Prezime { get; set; } = default!;

    public virtual DateTime DatumRodjenja { get; set; }

    public virtual string BrojLk { get; set; } = default!;

    public virtual string MestoIzdavanja { get; set; } = default!;

    public virtual string BrTel { get; set; } = default!;

    public virtual string Adresa { get; set; } = default!;

    public virtual string Institucija { get; set; } = default!;

    public virtual string Zvanje { get; set; } = default!;

    public virtual DateTime DatumSticanja { get; set; } = default!;

    /*[JsonIgnore]
    public virtual Licenca Licenca { get; set; }*/
}

public class UpravnikPregled
{
    public string Id { get; set; } = default!;
    public string JMBG { get; set; } = default!;
    public string Ime { get; set; } = default!;
    public string ImeRoditelja { get; set; } = default!;
    public string Prezime { get; set; } = default!;
    public DateTime DatumRodjenja { get; set; } = default!;
    public string BrojLk { get; set; } = default!;
    public string MestoIzdavanja { get; set; } = default!;
    public string BrTel { get; set; } = default!;
    public string Adresa { get; set; } = default!;
    public string Institucija { get; set; } = default!;
    public string Zvanje { get; set; } = default!;
    public DateTime DatumSticanja { get; set; } = default!;
}
#endregion

#region Ugovor
public class UgovorBasic
{
    public string Sifra { get; set; } = default!;
    public DateTime PeriodVazenja { get; set; }
}

public class UgovorPregled
{
    public int Id { get; set; }
    public int Sifra { get; set; }
    public DateTime DatumPotpisivanja { get; set; }
    public int PeriodVazenja { get; set; }
    public UpravnikPregled UpravnikId { get; set; } = default!;
    public ZgradaPregled ZgradaId { get; set; } = default!;
}
#endregion

#region Licenca
public class LicencaBasic
{
    public string BrojLicence { get; set; } = default!;
    public string Institucija { get; set; } = default!;
}

public class LicencaPregled
{
    public string Id { get; set; } = default!;
    public string BrojLicence { get; set; } = default!;
    public string Institucija { get; set; } = default!;
    public DateTime DatumSticanja { get; set; }
    public Upravnik Upravnik { get; set; } = default!;    
    
    public LicencaPregled(string id,string brojLicence,string ins,DateTime datumS,Upravnik upravnik)
    {
        Id = id;
        BrojLicence = brojLicence;
        Institucija = ins;
        DatumSticanja = datumS;
        Upravnik=upravnik;
    }
}
#endregion

#region Ulazi
public class UlaziBasic
{
    public int RedniBroj { get; set; }
    public int Kamera { get; set; }
    public string Otvoren { get; set; } = default!;   
}

public class UlaziPregled
{
    public string Id { get; set; } = default!;
    public int RedniBroj { get; set; }
    public int Kamera { get; set; }
    public string Otvoren { get; set; } = default!;
    public ZgradaBasic Zgrada { get; set; }  = default!;  
    
    public UlaziPregled(string id, int rednibr, int kamera, string otvoren)
    {
        this.Id= id;
        this.RedniBroj= rednibr;
        this.Kamera= kamera;
        this.Otvoren= otvoren;
    }
}
#endregion

#region Lift
public class LiftBasic
{
    public string SerijskiBroj { get; set; } = default!;
    public string Proizvodjac { get; set; } = default!;
    public DateTime DatumServisiranja { get; set; }
    public DateTime DatumKvara { get; set; }
    public int DaniVanUpotrebe { get; set; }
    public string Tip { get; set; } = default!;
    public int Nosivost { get; set; }
    public int BrojOsoba { get; set; }

}

public class LiftPregled
{
    public string SerijskiBroj { get; set; } = default!;
    public ZgradaPregled zgrada { get; set; } = default!;
    public string Proizvodjac { get; set; } = default!;
    public DateTime DatumServisiranja { get; set; }
    public DateTime DatumKvara { get; set; }
    public int DaniVanUpotrebe { get; set; }
    public string Tip { get; set; } = default!;
    public int Nosivost { get; set; }
    public int BrojOsoba { get; set; }

    public LiftPregled(string sb,string pr,string t,int nos,int bro)
    {
        SerijskiBroj=sb;
        Proizvodjac=pr;
        Tip = t;
        Nosivost = nos;
        BrojOsoba=bro;
    }
    public LiftPregled() { }
}

#endregion

#region Lokal
public class LokalBasic
{
    public string Id { get; set; } = default!;
    public string ImeFirme { get; set; } = default!;
}

public class LokalPregled
{
    public string Id { get; set; }
    public string ImeFirme { get; set; } = default!;
    public PoslovniProstor Prostor { get; set; } = default!;

    public LokalPregled(string id, string imeFirme, PoslovniProstor prostor)
    {
        Id = id;
        ImeFirme = imeFirme;
        Prostor = prostor;
    }
}
#endregion

#region PoslovniProstor

public class PoslovniProstorBasic
{
    public string Id { get; set; } = default!;

    public Zgrada Zgrada { get; set; } = default!;
    public int RedniBroj { get; set; }
    [JsonIgnore]
    public virtual IList<LokalBasic> Lokali { get; set; }=new List<LokalBasic>();       
}

public class PoslovniProstorPregled
{
    public string Id { get; set; } = default!;
    public int RedniBroj { get; set; }
    public Zgrada Zgrada { get; set; } = default!;   
    
    public PoslovniProstorPregled(string id,int redniBroj,Zgrada zgrada)
    {
        Id = id;
        RedniBroj = redniBroj;
        Zgrada = zgrada;
    }
}
#endregion

#region StambeniProstor
public class StambeniProstorBasic
{
    public string Id { get; set; } = default!;
    public Zgrada Zgrada { get; set; } = default!;

    public int BrojSprata { get; set; }
    [JsonIgnore]
    public virtual IList<StanBasic> Stanovi { get; set; } = new List<StanBasic>();        
}

public class StambeniProstorPregled
{
    public string Id { get; set; } = default!;
    public int BrojSprata { get; set; }
    [JsonIgnore]
    public Zgrada Zgrada { get; set; } = default!;

    public StambeniProstorPregled()
    {
    }

    public StambeniProstorPregled(string id, int brojSprata, Zgrada zgrada)
    {
        Id = id;
        BrojSprata = brojSprata;
        Zgrada = zgrada;
    }
}
#endregion

#region Stan
public class StanBasic
{
    public int BrojStana { get; set; }
    public int Povrsina { get; set; }
}

public class StanPregled
{
    public string Id { get; set; } = default!;
    public int BrojStana { get; set; }
    public int Povrsina { get; set; }
    public VlasnikPregled Vlasnik { get; set; } = default!;
    public StambeniProstorPregled StambeniProstor { get; set; } = new();

    public StanPregled(string id, int brojStana, int povrsina, VlasnikPregled vlasnik, StambeniProstorPregled stambeniProstor)
    {
        Id = id;
        BrojStana = brojStana;
        Povrsina = povrsina;
        Vlasnik = vlasnik;
        StambeniProstor = stambeniProstor;
    }
}
    #endregion

    #region Vlasnik
    public class VlasnikBasic
    {
        public string Id { get; set; } = default!;
        public string JMBG { get; set; } = default!;
        public string Ime { get; set; } = default!;
        public string ImeRoditelja { get; set; } = default!;
        public string Prezime { get; set; } = default!;
        public string BrojTelefona { get; set; } = default!;
        public string Adresa { get; set; } = default!;
        public string Funkcija { get; set; } = default!;
    }

    public class VlasnikPregled
    {
        public string Id { get; set; } = default!;
        public string JMBG { get; set; } = default!;
        public string Ime { get; set; } = default!;
        public string ImeRoditelja { get; set; } = default!;
        public string Prezime { get; set; } = default!;
        public string BrojTelefona { get; set; } = default!;
        public string Adresa { get; set; } = default!;
        public string Funkcija { get; set; } = default!;
        public IList<Stan> Stanovi { get; set; } = new List<Stan>();

    public VlasnikPregled() { }


    public VlasnikPregled(string id, string jMBG, string ime, string imeRoditelja, string prezime, string brojTelefona, string adresa, string funkcija,IList<Stan> st)
    {
        VlasnikPregled vlasnik = new VlasnikPregled();
        Id = id;
        JMBG = jMBG;
        Ime = ime;
        ImeRoditelja = imeRoditelja;
        Prezime = prezime;
        BrojTelefona = brojTelefona;
        Adresa = adresa;
        Funkcija = funkcija;
        Stanovi=st.ToList();
    }
}
    #endregion

    #region ParkingMesto
    public class ParkingMestoBasic
    {
        public string Id { get; set; } = default!;
        public string RegBroj { get; set; } = default!;
    }

    public class ParkingMestoPregled
    {
        public string Id;
        public string RegBroj = default!;
        public Garaza Garaza = default!;

    public ParkingMestoPregled(string id, string regBroj, Garaza garaza)
    {
        Id = id;
        RegBroj = regBroj;
        Garaza = garaza;
    }
}
    #endregion

    #region Garaza;
    public class GarazaBasic
    {
        public string GarazaId { get; set; } = default!;
        public int RedniBroj { get; set; }
    public Zgrada Zgrada { get; set; } = default!;

    public int BrParkingMesta { get; set; }
        [JsonIgnore]
        public virtual IList<ParkingMestoBasic> ParkingMesta { get; set; } = new List<ParkingMestoBasic>();
    }

    public class GarazaPregled
    {
        public string Id { get; set; }
        public int RedniBroj { get; set; }
        public Zgrada Zgrada { get; set; } = default!;

    public GarazaPregled(string id, int redniBroj, Zgrada zgrada)
    {
        Id = id;
        RedniBroj = redniBroj;
        Zgrada = zgrada;
    }
}

#endregion

