using NHibernate;
using NHibernate.Id.Insert;
using Projekat.Entiteti;
using Projekat.Extensions;
using System.ComponentModel.DataAnnotations;
using WinFormsUI;

namespace Projekat;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    //zgrada i ugovor
    //private async void CmdKreirajZgraduIUgovor_Click(object sender, EventArgs e)
    //{
    //    var zgrada = new ZgradaBasic
    //    {
    //        Adresa = "Pere perica",
    //        UpravnikId = "cWWRBm65A9OvPOymKeccA28/6W0="
    //    };

    //    var ugovor = new UgovorBasic
    //    {
    //        Sifra = "peraperapera",
    //        PeriodVazenja = DateTime.Now.AddMonths(6)
    //    };

    //    await DTOManager.SacuvajZgraduAsync(zgrada, ugovor, "cWWRBm65A9OvPOymKeccA28/6W0=");

    //    MessageBox.Show("Uspesno dodata zgrada");
    //}

    //licenca
    private async void CmdKreirajLicencu_Click(object sender, EventArgs e)
    {
        var licenca = new LicencaBasic
        {
            BrojLicence = Mapper.GenerateId(),
            Institucija = "Institucija"
        };

        await DTOManager.SacuvajLicencuAsync(licenca);

        MessageBox.Show("Uspesno dodata licencaaaaa!");
    }

    private async void CmdKreirajUpravnika_Click(object sender, EventArgs e)
    {
        var upravnik = new UpravnikBasic
        {
            JMBG = "2131232131246",
            Ime = "Marko",
            ImeRoditelja = "Neko",
            Prezime = "Nikolic",
            DatumRodjenja = DateTime.UtcNow,
            BrojLk = "421421321",
            MestoIzdavanja = "Beograd",
            BrTel = "32132131",
            Adresa = "Markova 17",
            Institucija = "Elfak",
            Zvanje = "Diplomirani drMr",
            DatumSticanja = DateTime.UtcNow,
        };

        await DTOManager.SacuvajUpravnikaAsync(upravnik, "ZiARb/Vk6rxHXocJNI8ECqR9Z5c=");

        MessageBox.Show("Upravnik");
    }

    private async void CmdKreirajUlaz_Click(object sender, EventArgs e)
    {
        var ulaz1 = new UlaziBasic
        {
            Kamera = 0,
            RedniBroj = 1,
            Otvoren = "08-10"
        };

        var ulaz2 = new UlaziBasic
        {
            Kamera = 1,
            RedniBroj = 2,
            Otvoren = "08-20"
        };

        await DTOManager.SacuvajUlazAsync(ulaz1, "UU0jejLR+hO+yh/ZL4Adz+G0gkI=");
        await DTOManager.SacuvajUlazAsync(ulaz2, "UU0jejLR+hO+yh/ZL4Adz+G0gkI=");
        MessageBox.Show("Ulaz");

    }

    private async void CmdKreirajLift_Click(object sender, EventArgs e)
    {
        var lift1 = new LiftBasic
        {
            SerijskiBroj = "147558984",
            Proizvodjac = "Simens",
            DatumKvara = DateTime.Parse("22/06/2001"),
            DatumServisiranja = DateTime.Parse("28/04/2002"),
            Nosivost = 200,
            Tip = "TERETNI"
        };

        var lift2 = new LiftBasic
        {
            SerijskiBroj = "234951188",
            Proizvodjac = "Sony",
            DatumKvara = DateTime.Parse("22/06/2003"),
            DatumServisiranja = DateTime.Parse("28/08/2005"),
            BrojOsoba = 16,
            Nosivost = 1000,
            Tip = "PUTNICKI"
        };

        await DTOManager.SacuvajLiftAsync(lift1, "TRROWx6K+NQYpIzha7bsdTA94gQ=");
        await DTOManager.SacuvajLiftAsync(lift2, "ZCv2f5UkWYdh/wD712Mf50z0gnQ=");
        MessageBox.Show("Lift");
    }

    //private async void CmdKreirajGarazu_Click(object sender, EventArgs e)
    //{
    //    var garaza = new GarazaBasic
    //    {
    //        RedniBroj = 4
    //    };

    //    await DTOManager.SacuvajGarazuAsync(garaza, "UU0jejLR+hO+yh/ZL4Adz+G0gkI=");
    //    MessageBox.Show("garaza");
    //}

    private async void CmdKreirajStambeniProstor_Click(object sender, EventArgs e)
    {
        var stambeniProstor = new StambeniProstorBasic
        {
            BrojSprata = 3
        };

        await DTOManager.SacuvajStambeniProstorAsync(stambeniProstor, "UU0jejLR+hO+yh/ZL4Adz+G0gkI=");
        MessageBox.Show("stambeni prostor");
    }

    private async void CmdKreirajPoslovniProstor_Click(object sender, EventArgs e)
    {
        var poslovniProstor = new PoslovniProstorBasic
        {
            RedniBroj = 6
        };

        await DTOManager.SacuvajPoslovniProstorAsync(poslovniProstor, "UU0jejLR+hO+yh/ZL4Adz+G0gkI=");
        MessageBox.Show("poslovni prostor");
    }

    //private async void CmdKreirajParkingMesto_Click(object sender, EventArgs e)
    //{
    //    var parkingMesto1 = new ParkingMestoBasic
    //    {
    //        RegBroj = "PK-077-ZA"
    //    };

    //    var parkingMesto2 = new ParkingMestoBasic
    //    {
    //        RegBroj = "PK-078-TE"
    //    };

    //    await DTOManager.SacuvajParkingMestoAsync(parkingMesto1, "lb4Ao0PVoP5HKgUiA5+quV9BmBM=");
    //    await DTOManager.SacuvajParkingMestoAsync(parkingMesto2, "lb4Ao0PVoP5HKgUiA5+quV9BmBM=");
    //    MessageBox.Show("parking mesto");
    //}

    private async void CmdKreirajLokal_Click(object sender, EventArgs e)
    {
        var lokal1 = new LokalBasic
        {
            ImeFirme = "MUNJA TRANS"
        };

        var lokal2 = new LokalBasic
        {
            ImeFirme = "DELTA BUILD"
        };

        await DTOManager.SacuvajLokalAsync(lokal1, "ouCfabxrDNdaScL7wdWawChQYvc=");
        await DTOManager.SacuvajLokalAsync(lokal2, "ouCfabxrDNdaScL7wdWawChQYvc=");
        MessageBox.Show("lokal");
    }

    private async void DodajStan_Click(object sender, EventArgs e)
    {
        var stan = new StanBasic
        {
            BrojStana = 10,
            Povrsina = 150

        };
        await DTOManager.SacuvajStanAsync(stan, "7CoNsU7e1Hj7W5l7RI6Zknfz6ss=");
        MessageBox.Show("Uspesno dodat stan");
    }

    //private async void CmdKreirajVlasnika_Click(object sender, EventArgs e)
    //{
    //    var vlasnik1 = new VlasnikBasic
    //    {
    //        JMBG = "12345886",
    //        Ime = "sreta",
    //        ImeRoditelja = "dobrica",
    //        Prezime = "matic",
    //        BrojTelefona = "06454545454",
    //        Adresa = "mokranjceva 1",
    //        Funkcija = "predsednik"
    //    };
    //    var vlasnik2 = new VlasnikBasic
    //    {
    //        JMBG = "116756",
    //        Ime = "pera",
    //        ImeRoditelja = "vlada",
    //        Prezime = "kovacevic",
    //        BrojTelefona = "0621213432",
    //        Adresa = "rajiceva 3",
    //        Funkcija = "blagajnik"
    //    };

    //    await DTOManager.SacuvajVlasnikaAsync(vlasnik1, "m4dKXqp0Q/s7VXiuU6BpHX0VWQU=");
    //    await DTOManager.SacuvajVlasnikaAsync(vlasnik2, "522tB9Hx3aHeHF1C+BWsiMbqQSY=");
    //    MessageBox.Show("Uspesno dodat vlasnik");
    //}

    private async void CmdDodajZgradu_Click(object sender, EventArgs e)
    {

        var zgrada = new ZgradaBasic
        {
            Adresa = "Toplicina 4"
        };

        // await DTOManager.SacuvajZgraduAsync(zgrada);

        MessageBox.Show("Uspesno dodata zgrada");

    }

    private async void CmdDodajUgovor_Click(object sender, EventArgs e)
    {
        UgovorBasic ugovorModel = new UgovorBasic
        {
            Sifra = "isadhi5",
            PeriodVazenja = DateTime.Parse("25/04/2024")
        };

        await DTOManager.SacuvajUgovorAsync(ugovorModel, "Ma7ZAfAUFhOey56R4l5kqWPXs40=");

        MessageBox.Show("Uspesno dodat ugovor");
    }

    private void CmdUcitajZgradu_Click(object sender, EventArgs e)
    {
        var zgrada = DTOManager.VratiZgradu("UU0jejLR+hO+yh/ZL4Adz+G0gkI=");
    }

    private async void CmdObrisiStan_Click(object sender, EventArgs e)
    {
        await DTOManager.ObrisiStanAsync("YTWpCb+STueDlg8CuHtYeTVA0eE=");
    }

    /*private void CmdVratiStanove_Click(object sender, EventArgs e)
    {
        List<StanPregled> stanPregledi = DTOManager.VratiStanovePremaVlasniku("xvvOaOW1kJoDU6kjIrsC2a6fXi4=");

    }*/


    private async void CmdIzmeniUgovor_Click(object sender, EventArgs e)
    {
        await DTOManager.IzmeniUgovorAsync("gkSA5TstM8UZ2CEyIhSmYvJLJXU=");
    }

    private async void CmdIzmeniUpravnika_Click(object sender, EventArgs e)
    {
        // await DTOManager.IzmeniUpravnikaAsync("cWWRBm65A9OvPOymKeccA28/6W0=");
    }

    private void CmdVratiLiftovePoTipu_Click(object sender, EventArgs e)
    {
        IList<LiftPregled> l = DTOManager.VratiLiftovePoTipuAsync();

    }

    private void button9_Click(object sender, EventArgs e)
    {

    }

    private void pocetna_Click(object sender, EventArgs e)
    {
        PocetnaStranica form = new PocetnaStranica();

        form.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {

    }

    private void button19_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void btnAddAgenciju_Click(object sender, EventArgs e)
    {
    }

    private void button5_Click(object sender, EventArgs e)
    {

    }
}
