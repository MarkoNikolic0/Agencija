using NHibernate;
using NHibernate.Linq;
using Projekat.Entiteti;
using Projekat.Extensions;
using System.Data.Common;
using System.Transactions;

namespace Projekat;

public static class DTOManager
{
    #region Zgrada
    public static async Task ObrisiZgradu(string id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            Zgrada? o = (from u in s.Query<Zgrada>()
                         where u.Id == id
                         select u).FirstOrDefault();

            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
    }

    public async static Task<ZgradaPregled> VratiZgradu(string id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            Zgrada zgrada = await s.LoadAsync<Zgrada>(id);

            var result = zgrada.Map1();

            return result;
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
            return new ZgradaPregled();
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
    }

    public async static Task<List<ZgradaPregled>> VratiZgrade()
    {
        ISession? s = null;
        List<ZgradaPregled> zgrade = new List<ZgradaPregled>();
        try
        {
            s = DataLayer.GetSession();

            IEnumerable<Zgrada> sveZgrade = await s.Query<Zgrada>().ToListAsync();

            foreach (Zgrada p in sveZgrade)
            {
                zgrade.Add(new ZgradaPregled { Id = p.Id, Adresa = p.Adresa, Ugovor = p.UgovorId, Upravnik = p.UpravnikId });
            }
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return zgrade;
    }

    /*public static IEnumerable<ZgradaBasic> VratiSpecZgrade(string ugovorId)
    {
        List<ZgradaBasic> SpecZgrade = new();
        try
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Zgrada> zgrade = from z in s.Query<Zgrada>()
                                         where z.UgovorId.Id == ugovorId
                                         select z;
            List<ZgradaBasic> result = zgrade.Map();
            return result;
        }
        catch(Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
            return Enumerable.Empty<ZgradaBasic>();
        }
    }*/

    //public static bool IzmeniZgradu(ZgradaBasic zgrada)
    //{
    //    try
    //    {
    //        ISession s = DataLayer.GetSession();
    //        Zgrada z = s.Load<Zgrada>(zgrada.Id);

    //        z.Adresa = zgrada.Adresa;

    //        s.SaveOrUpdate(z);

    //        s.Flush();

    //        s.Close();
    //        return true;
    //    }
    //    catch(Exception e)
    //    {
    //        string error = e.Message;
    //        Console.WriteLine(error);
    //        return false;
    //    }
    //}

    /*public static async Task SacuvajZgraduAsync1(ZgradaBasic zgradaModel, UgovorBasic ugovorModel ,string upravnikId)
    {
        ISession s = DataLayer.GetSession();

        ITransaction transaction = s.BeginTransaction();
        try
        {
            Upravnik upravnik = s.Load<Upravnik>(upravnikId);
            Ugovor ugovor = ugovorModel.Map();
            Zgrada zgrada = zgradaModel.Map(ugovor, upravnik);

            upravnik.Zgrade.Add(zgrada);
            zgrada.UgovorId = ugovor;
            ugovor.ZgradaId = zgrada;

            await s.SaveOrUpdateAsync(upravnik);
            await s.SaveOrUpdateAsync(ugovor);              
            await s.SaveOrUpdateAsync(zgrada);
            await transaction.CommitAsync();

            s.Flush();
            s.Close();
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
            transaction.Rollback();
        }
        finally
        {
            await s.FlushAsync();
            s.Close();
        }
    }*/

    public static async Task<string> SacuvajZgraduAsync(ZgradaBasic zgradaModel, string upravnikId)
    {
        ISession? s = null;
        ITransaction? transaction = null;

        try
        {
            s = DataLayer.GetSession();
            transaction = s.BeginTransaction();
            Zgrada zgrada = zgradaModel.Map();
            /* Ugovor ugovor = await (from o in s.Query<Ugovor>()
                              where o.Id == ugovorId
                              select o).FirstOrDefaultAsync();*/
            Upravnik upravnik = await (from o in s.Query<Upravnik>()
                                       where o.Id == upravnikId
                                       select o).FirstOrDefaultAsync();
            if (upravnik == null)
            {
                return "Ne postoji upravnik sa tim id-jem";
            }

            zgrada.UpravnikId = upravnik;
            /*zgrada.UgovorId = ugovor;*/

            await s.SaveOrUpdateAsync(zgrada);
            await s.FlushAsync();
            await transaction.CommitAsync();
            return "Uspesno dodata zgrada";

        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
            transaction?.Rollback();
            return "Došlo je do greške prilikom čuvanja zgrade.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
    }//u upotrebi

    public static async Task SacuvajUlazAsync(UlaziBasic ulazModel, string zgradaId)
    {
        ISession? s = null;

        ITransaction? transaction = null;
        try
        {
            s = DataLayer.GetSession();
            transaction = s.BeginTransaction();

            Zgrada zgrada = s.Load<Zgrada>(zgradaId);
            Ulaz ulaz = ulazModel.Map();

            zgrada.Ulazi.Add(ulaz);
            ulaz.ZgradaId = zgrada;

            await s.SaveOrUpdateAsync(ulaz);
            await s.SaveOrUpdateAsync(zgrada);
            await transaction.CommitAsync();

            await s.FlushAsync();
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
            transaction?.Rollback();
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
    }//u upotrebi

    public static async Task SacuvajLiftAsync(LiftBasic liftModel, string zgradaId)
    {
        ISession s = DataLayer.GetSession();

        try
        {
            Zgrada zgrada = s.Load<Zgrada>(zgradaId);
            Lift lift = liftModel.Map();

            zgrada.Liftovi.Add(lift);
            lift.ZgradaId = zgrada;

            await s.SaveOrUpdateAsync(lift);
            await s.SaveOrUpdateAsync(zgrada);

            await s.FlushAsync();
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
    }//u upotrebi

    public static List<UlaziPregled> vratiUlazeZgrade(string zgradaId)
    {
        ISession? s = null;

        List<UlaziPregled> odInfos = new List<UlaziPregled>();
        try
        {
            s = DataLayer.GetSession();

            IEnumerable<Ulaz> ulazi = from o in s.Query<Ulaz>()
                                      where o.ZgradaId.Id == zgradaId
                                      select o;

            foreach (Ulaz o in ulazi)
            {
                zgradaId = o.ZgradaId.Id;
                odInfos.Add(new UlaziPregled(o.Id, o.RedniBroj, o.Kamera, o.Otvoren));
            }

        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return odInfos;
    }//u upotrebi

    public async static Task<List<LiftPregled>> vratiLiftoveZgrade(string zgradaId)
    {
        ISession? s = null;
        List<LiftPregled> odInfos = new List<LiftPregled>();
        try
        {
            s = DataLayer.GetSession();

            IEnumerable<Lift> liftovi = await s.Query<Lift>()
                                .Where(o => o.ZgradaId.Id == zgradaId)
                                .ToListAsync();

            foreach (Lift o in liftovi)
            {
                zgradaId = o.ZgradaId.Id;
                odInfos.Add(new LiftPregled(o.SerijskiBroj, o.Proizvodjac, o.Tip, o.Nosivost, o.BrojOsoba));
            }

        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return odInfos;
    }//u upotrebi

    public static IList<LiftPregled> VratiLiftovePoTipuAsync()
    {
        ISession? s = null;
        List<LiftPregled> liftPr = new List<LiftPregled>();
        try
        {
            s = DataLayer.GetSession();

            IEnumerable<Lift> liftovi = s.Query<Lift>()
                                        .Where(p => p.Tip == "TERETNI")
                                        .OrderBy(p => p.SerijskiBroj.Length)
                                        .Select(p => p);

            foreach (Lift lift in liftovi)
            {
                string sb = lift.SerijskiBroj;
                string pr = lift.Proizvodjac;
                int bo = lift.BrojOsoba;
                int nos = lift.Nosivost;
                string message = string.Format("{0}\n {1}\n {2}\n {3} ", sb, pr, bo, nos);
                Console.WriteLine(message);
                liftPr.Add(new LiftPregled(lift.SerijskiBroj, lift.Proizvodjac, lift.Tip, lift.Nosivost, lift.BrojOsoba));

                s.Flush();
            }
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
        }
        return liftPr;
    }
    #endregion

    #region Agencija

    public static List<AgencijaPregled> VratiAgencije()
    {
        List<AgencijaPregled> agencije = new List<AgencijaPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Projekat.Entiteti.Agencija> sveAgencije = from o in s.Query<Projekat.Entiteti.Agencija>()
                                                                  select o;

            foreach (Projekat.Entiteti.Agencija p in sveAgencije)
            {
                agencije.Add(new AgencijaPregled { Id = p.Id, Ime = p.Ime });
            }

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return agencije;
    }

    #endregion

    #region Garaza

    public static void ObrisiGarazu(string id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Garaza garaza = s.Load<Garaza>(id);

            s.Delete(garaza);
            s.Flush();
            s.Close();
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
    }

    public async static Task<List<ParkingMestoPregled>> vratiParkingMestaZgrade(string zgradaId)
    {
        ISession? s = null;

        List<ParkingMestoPregled> odInfos = new List<ParkingMestoPregled>();
        try
        {
            s = DataLayer.GetSession();

            IEnumerable<ParkingMesto> parkingMesta = await s.Query<ParkingMesto>()
                                .Where(o => o.GarazaId.ZgradaId.Id == zgradaId)
                                .ToListAsync();

            foreach (ParkingMesto o in parkingMesta)
            {
                zgradaId = o.GarazaId.ZgradaId.Id;
                odInfos.Add(new ParkingMestoPregled(o.Id, o.RegBroj, o.GarazaId));
            }

        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return odInfos;
    }

    public async static Task<List<StambeniProstorPregled>> VratiStambeniProstor(string zgradaId)
    {
        ISession? s = null;
        List<StambeniProstorPregled> odInfos = new List<StambeniProstorPregled>();
        try
        {
            s = DataLayer.GetSession();

            IEnumerable<StambeniProstor> stambeniProstor = await s.Query<StambeniProstor>()
                                .Where(o => o.ZgradaId.Id == zgradaId)
                                .ToListAsync();

            foreach (StambeniProstor o in stambeniProstor)
            {
                zgradaId = o.ZgradaId.Id;
                odInfos.Add(new StambeniProstorPregled(o.Id,o.BrojSprata,o.ZgradaId));
            }

        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return odInfos;
    }

    public async static Task<List<PoslovniProstorPregled>> VratiPoslovniProstor(string zgradaId)
    {
        ISession? s = null;
        List<PoslovniProstorPregled> odInfos = new List<PoslovniProstorPregled>();
        try
        {
            s = DataLayer.GetSession();

            IEnumerable<PoslovniProstor> poslovniProstor = await s.Query<PoslovniProstor>()
                                .Where(o => o.ZgradaId.Id == zgradaId)
                                .ToListAsync();

            foreach (PoslovniProstor o in poslovniProstor)
            {
                zgradaId = o.ZgradaId.Id;
                odInfos.Add(new PoslovniProstorPregled(o.Id,o.RedniBroj,o.ZgradaId));
            }

        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return odInfos;
    }

    public async static Task<List<GarazaPregled>> VratiGarazu(string zgradaId)
    {
        ISession? s = null;
        List<GarazaPregled> odInfos = new List<GarazaPregled>();
        try
        {
            s = DataLayer.GetSession();

            IEnumerable<Garaza> garaza = await s.Query<Garaza>()
                                .Where(o => o.ZgradaId.Id == zgradaId)
                                .ToListAsync();

            foreach (Garaza o in garaza)
            {
                zgradaId = o.ZgradaId.Id;
                odInfos.Add(new GarazaPregled(o.Id,o.RedniBroj,o.ZgradaId));
            }

        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return odInfos;
    }

    //public static List<GarazaBasic> VratiSpecGarazu(int zgradaId)
    //{
    //    List<GarazaBasic> SpecGaraze = new List<GarazaBasic>();
    //    try
    //    {
    //        ISession s = DataLayer.GetSession();

    //        IEnumerable<Garaza> garaze = from g in s.Query<Garaza>()
    //                                     where g.ZgradaId.Id == zgradaId
    //                                     select g;
    //        foreach (Garaza g in garaze)
    //        {
    //            SpecGaraze.Add(new GarazaBasic(g.GarazaId, g.ZgradaId.Id, g.ZgradaId.Id, g.ParkingMesta.Count));
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        string error = e.Message;
    //        Console.WriteLine(error);
    //    }
    //    return SpecGaraze;
    //}

    public static void IzmeniGarazu(GarazaBasic garaza)
    {
        try
        {
            ISession s = DataLayer.GetSession();
            Projekat.Entiteti.Garaza g = s.Load<Garaza>(garaza.GarazaId);

            g.RedniBroj = garaza.RedniBroj;

            s.SaveOrUpdate(g);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static async Task<string> SacuvajGarazuAsync(GarazaBasic garazaModel, string zgradaId)
    {
        ISession s = DataLayer.GetSession();

        ITransaction transaction = s.BeginTransaction();
        try
        {
            Garaza garaza = garazaModel.Map();
            Zgrada zgrada = s.Load<Zgrada>(zgradaId);

            garaza.ZgradaId = zgrada;
            await s.SaveOrUpdateAsync(garaza);
            await transaction.CommitAsync();
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
            transaction.Rollback();
        }
        finally
        {
            await s.FlushAsync();
            s?.Close();
        }
        return "Uspesno sacuvana garaza";
    }//u upotrebi

    //public static async Task SacuvajParkingMestoAsync(ParkingMestoBasic parkingMestoModel, string garazaId)
    //{
    //    ISession s = DataLayer.GetSession();
    //    ITransaction transaction = s.BeginTransaction();
    //    try
    //    {
    //        ParkingMesto parkingMesto = parkingMestoModel.Map();
    //        Garaza garaza = s.Load<Garaza>(garazaId);

    //        parkingMesto.GarazaId = garaza;
    //        garaza.ParkingMesta.Add(parkingMesto);

    //        await s.SaveOrUpdateAsync(parkingMesto);
    //        await s.SaveOrUpdateAsync(garaza.ParkingMesta);
    //        await transaction.CommitAsync();
    //    }
    //    catch (Exception e)
    //    {
    //        string error = e.Message;
    //        Console.WriteLine(error);
    //        transaction.Rollback();
    //    }
    //    finally
    //    {
    //        await s.FlushAsync();
    //        s.Close();
    //    }
    //}
    #endregion

    #region StambeniProstor

    public static async Task<string> SacuvajStambeniProstorAsync(StambeniProstorBasic stambeniProstorModel, string zgradaId)
    {
        ISession s = DataLayer.GetSession();
        ITransaction transaction = s.BeginTransaction();
        try
        {
            StambeniProstor stambeniProstor = stambeniProstorModel.Map();
            Zgrada zgrada = s.Load<Zgrada>(zgradaId);

            stambeniProstor.ZgradaId = zgrada;
            await s.SaveOrUpdateAsync(stambeniProstor);
            await transaction.CommitAsync();
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
            transaction.Rollback();
        }
        finally
        {
            await s.FlushAsync();
            s.Close();
        }
        return "Uspesno sacuvan stambeni prostor";
    }//u upotrebi

    #endregion

    #region PoslovniProstor

    public static async Task<string> SacuvajPoslovniProstorAsync(PoslovniProstorBasic poslovniProstorModel, string zgradaId)
    {
        ISession s = DataLayer.GetSession();
        ITransaction transaction = s.BeginTransaction();
        try
        {
            PoslovniProstor poslovniProstor = poslovniProstorModel.Map();
            Zgrada zgrada = s.Load<Zgrada>(zgradaId);

            poslovniProstor.ZgradaId = zgrada;
            await s.SaveOrUpdateAsync(poslovniProstor);
            await transaction.CommitAsync();
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
            transaction.Rollback();
        }
        finally
        {
            await s.FlushAsync();
            s.Close();
        }
        return "Uspesno dodat poslovni prostor";
    }//u upotrebi

    public static async Task SacuvajLokalAsync(LokalBasic lokalModel, string poslovniProstorId)
    {
        ISession s = DataLayer.GetSession();
        ITransaction transaction = s.BeginTransaction();

        try
        {
            Lokal lokal = lokalModel.Map();
            PoslovniProstor poslovniProstor = s.Load<PoslovniProstor>(poslovniProstorId);

            lokal.ProstorId = poslovniProstor;
            poslovniProstor.Lokali.Add(lokal);

            await s.SaveOrUpdateAsync(lokal);
            await s.SaveOrUpdateAsync(poslovniProstor);
            await transaction.CommitAsync();
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
            transaction.Rollback();
        }
        finally
        {
            await s.FlushAsync();
            s.Close();
        }

    }

    public async static Task<List<LokalPregled>> vratiLokaleZgrade(string zgradaId)
    {
        ISession? s = null;
        List<LokalPregled> odInfos = new List<LokalPregled>();
        try
        {
            s = DataLayer.GetSession();            

            IEnumerable<Lokal> lokali = await s.Query<Lokal>()
                               .Where(o => o.ProstorId.ZgradaId.Id == zgradaId)
                               .ToListAsync();

            foreach (Lokal o in lokali)
            {
                zgradaId = o.ProstorId.ZgradaId.Id;
                odInfos.Add(new LokalPregled(o.Id,o.ImeFirme,o.ProstorId));
            }
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return odInfos;
    }//u upotrebi

    #endregion

    #region Ugovor

    /*public static void obrisiUgovor(int ugovorId)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Ugovor ugovor = s.Load<Ugovor>(ugovorId);

            s.Delete(ugovor);
            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {

        }
    }*/

    /*public static UgovorBasic VratiUgovor(int Id)
    {
        UgovorBasic ug = new UgovorBasic();
        try
        {
            ISession s = DataLayer.GetSession();

            Ugovor ugovor = s.Load<Ugovor>(Id);

            ug.Sifra = ugovor.Sifra;
            ug.PeriodVazenja = ugovor.PeriodVazenja;

            s.Close();
        }
        catch (Exception e) 
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        return ug;
    }*/

    public static async Task SacuvajUgovorAsync(UgovorBasic ugovorModel, string zgradaId)
    {
        ISession s = DataLayer.GetSession();

        ITransaction transaction = s.BeginTransaction();
        try
        {
            Zgrada zgrada = s.Load<Zgrada>(zgradaId);
            Ugovor ugovor = ugovorModel.Map();

            ugovor.ZgradaId = zgrada;
            zgrada.UgovorId = ugovor;

            await s.SaveOrUpdateAsync(zgrada);
            await s.SaveOrUpdateAsync(ugovor);
            await transaction.CommitAsync();

            /*s.Flush();
            s.Close();*/
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
            transaction.Rollback();
        }
        finally
        {
            await s.FlushAsync();
            s.Close();
        }
    }

    //public static List<UgovorBasic> VratiUgovorePremaZgradi(int zgradaId)
    //{
    //    List<UgovorBasic> ugovoriPrZg = new List<UgovorBasic>();
    //    try
    //    {
    //        ISession s = DataLayer.GetSession();

    //        IEnumerable<Ugovor> ugovori = from u in s.Query<Ugovor>()
    //                                      where u.ZgradaId.Id == zgradaId
    //                                      select u;

    //        foreach (Ugovor u in ugovori)
    //        {
    //            ugovoriPrZg.Add(new UgovorBasic(u.Id, u.Sifra, u.DatumPotpisivanja, u.PeriodVazenja, u.UpravnikId.Id, u.ZgradaId.Id));
    //        }
    //    }
    //    catch (Exception e)
    //    {

    //    }
    //    return ugovoriPrZg;
    //}

    public async static Task IzmeniUgovorAsync(string ugovorId)
    {
        ISession? s =null;
        try
        {
            s = DataLayer.GetSession();

            Ugovor u = s.Load<Ugovor>(ugovorId);

            u.Sifra ="sifraaa";
            u.DatumPotpisivanja =DateTime.Parse("28/01/2003");

            await s.SaveOrUpdateAsync(u);

            await s.FlushAsync();
            Console.WriteLine("Izmenjen ugovor");
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);          
        }
        finally
        {           
            s?.Close();
        }
    }

    #endregion

    #region Stan

    public async static Task ObrisiStanAsync(string stanid)
    {
        ISession s = DataLayer.GetSession();
        try
        {           
            Stan stan = s.Load<Stan>(stanid);
            StambeniProstor stambeni = s.Load<StambeniProstor>(stan.StambeniProstorId.Id);

            VlasnikPregled v = await VratiVlasnikaPremaStanu(stan.Id);
            v.Stanovi.Remove(stan);
            if (v.Stanovi.Count == 0)
            {
                await s.DeleteAsync(v);
            }
            stambeni.Stanovi.Remove(stan);
            await s.DeleteAsync(stan);
            await s.SaveOrUpdateAsync(stambeni);

            await s.FlushAsync();

        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s.Close();
            s.Dispose();
        }
    }//u upotrebi

    /*public static StanBasic VratiStan(string stanId)
    {
        StanBasic st = new StanBasic();
        try
        {
            ISession s = DataLayer.GetSession();

            Stan stan = s.Load<Stan>(stanId);

            st.BrojStana = stan.BrojStana;
            st.Povrsina= stan.Povrsina;

            s.Close();
        }
        catch(Exception e) { }
        return st;
    }*/

    /*public static List<StanPregled> VratiStanovePremaVlasniku(string vlasnikId)
    {
        ISession? s = null;
        List<StanPregled> stanoviVl = new List<StanPregled>();
        try
        {
            s = DataLayer.GetSession();

            IEnumerable<Stan> stanovi = from st in s.Query<Stan>()
                                        where st.VlasnikId.Id == vlasnikId
                                        select st;

            foreach (Stan st in stanovi)
            {
                stanoviVl.Add(new StanPregled
                {
                    Id= st.Id,
                    BrojStana = st.BrojStana,
                    Povrsina = st.Povrsina,
                    Vlasnik = st.VlasnikId,
                    StambeniProstor = st.StambeniProstorId
                });
            }
            s.Flush();
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {         
            s?.Close();
        }

        return stanoviVl;
    }*/

    public async static Task<VlasnikPregled> VratiVlasnikaPremaStanu(string stanId)
    {
        ISession? s = null;
        VlasnikPregled vlasnik = new VlasnikPregled();
        try
        {
            s = DataLayer.GetSession();

            Stan stan = await s.LoadAsync<Stan>(stanId);
            Vlasnik vl = await s.LoadAsync<Vlasnik>(stan.VlasnikId.Id);
            vlasnik = vl.Map1();   

            await s.FlushAsync();
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {         
            s?.Close();
            s?.Dispose();
        }

        return vlasnik;
    }//u upotrebi

    public async static Task<List<StanPregled>> vratiStanoveZgrade(string zgradaId)
    {
        ISession? s = null;

        List <StanPregled> odInfos = new List<StanPregled>();
        try
        {
            s = DataLayer.GetSession();

            StambeniProstor z = new StambeniProstor();
            Vlasnik v = new Vlasnik();

            IEnumerable<Stan> stanovi = await s.Query<Stan>()
                               .Where(o => o.StambeniProstorId.ZgradaId.Id == zgradaId)
                               .ToListAsync();

            foreach (Stan o in stanovi)
            {
                zgradaId = o.StambeniProstorId.ZgradaId.Id;
                if (o.VlasnikId != null)
                {
                    odInfos.Add(new StanPregled(o.Id, o.BrojStana, o.Povrsina, o.VlasnikId.Map1(), o.StambeniProstorId.Map1()));
                }
                else
                {
                    odInfos.Add(new StanPregled(o.Id, o.BrojStana, o.Povrsina, null!, o.StambeniProstorId.Map1()));
                }
            }
            return odInfos;
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }

        finally
        {
            s?.Close();
            s?.Dispose();           
        }
        return odInfos;
    }//u upotrebi

    /*public async static void IzmeniStan(StanBasic stan)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Stan st = new();

            st.BrojStana= stan.BrojStana;
            st.Povrsina= stan.Povrsina;

            s.SaveOrUpdate(st);

            s.Flush();

            s.Close();
        }
        catch(Exception e) 
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
    }*/

    /*public async static Task DodajVlasnikuStanAsync(string vlasnikId,string stanId)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();
            Stan stan= s.Load<Stan>(stanId);
            Vlasnik vlasnik = s.Load<Vlasnik>(vlasnikId);

            stan.VlasnikId = vlasnik;
            vlasnik.Stanovi.Add(stan);

            await s.SaveOrUpdateAsync(stan);
            await s.SaveOrUpdateAsync(vlasnik);
            await s.FlushAsync();
            Console.WriteLine("dodat stan");

        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

    }*/

    public static async Task<string> SacuvajStanAsync(StanBasic stanModel, string stambeniProstorId)
    {
        ISession? s = null;

        try
        {
            s= DataLayer.GetSession();

            StambeniProstor stambeniProstor = s.Load<StambeniProstor>(stambeniProstorId);

            Stan stan = stanModel.Map();
            stan.StambeniProstorId = stambeniProstor;
            stambeniProstor.Stanovi.Add(stan);

            await s.SaveOrUpdateAsync(stan);
            await s.SaveOrUpdateAsync(stambeniProstor);
            await s.FlushAsync();

        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return "Uspesno dodat stan";
    }//u upotrebi

    public static async Task<string> SacuvajVlasnikaAsync(VlasnikBasic vlasnikModel, string stanId)
    {
        ISession? s = null;

        try
        {           
            s = DataLayer.GetSession();
            Stan stan = await s.LoadAsync<Stan>(stanId);
            Vlasnik vlasnik = vlasnikModel.Map2();

            if (stan.VlasnikId != null)
                return "Ovaj stan vec ima vlasnika!";

            vlasnik.Stanovi.Add(stan);
            await s.SaveOrUpdateAsync(vlasnik);
            stan.VlasnikId = vlasnik;

            await s.SaveOrUpdateAsync(stan);
            await s.FlushAsync();
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return "Uspesno dodat vlasnik";
    }//u upotrebi

    #endregion

    #region Licenca

    public async static Task<string> SacuvajLicencuAsync(LicencaBasic licenca)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();
            
            Licenca licencaToAdd = licenca.Map();

            await s.SaveOrUpdateAsync(licencaToAdd);
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            await s.FlushAsync();
            s.Close();
        }
        return "Uspesno dodata licenca";
    }//u upotrebi

    public async static Task<List<LicencaPregled>> VratiLicence()
    {
        ISession? s = null;
        List<LicencaPregled> odInfos = new List<LicencaPregled>();
        try
        {
            s = DataLayer.GetSession();

            IEnumerable<Licenca> licence = await s.Query<Licenca>()
                               .ToListAsync();

            foreach (Licenca p in licence)
            {
                odInfos.Add(new LicencaPregled(p.Id,p.BrojLicence,p.Institucija,p.DatumSticanja,p.Upravnik));
            }
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return odInfos;
    }//u upotrebi

    #endregion

    #region Upravnik

    public async static Task<List<UpravnikPregled>> VratiUpravnike()
    {
        ISession? s = null;
        List<UpravnikPregled> upravnici = new List<UpravnikPregled>();
        try
        {
            s = DataLayer.GetSession();

            IEnumerable<Upravnik> sviUpravnici = await s.Query<Upravnik>()                               
                               .ToListAsync();

            foreach (Upravnik p in sviUpravnici)
            {
                upravnici.Add(new UpravnikPregled {Id=p.Id, JMBG = p.JMBG, Ime = p.Ime,ImeRoditelja = p.ImeRoditelja, Prezime = p.Prezime, DatumRodjenja = p.DatumRodjenja, BrojLk = p.BrojLk, MestoIzdavanja = p.MestoIzdavanja, BrTel = p.BrTel, Adresa = p.Adresa, Institucija = p.Institucija, Zvanje = p.Zvanje, DatumSticanja = p.DatumSticanja });
            }
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return upravnici;
    }//u upotrebi

    public async static Task<string> SacuvajUpravnikaAsync(UpravnikBasic upravnikDto, string licencaId)
    {
        ISession s = DataLayer.GetSession();

        ITransaction transaction = s.BeginTransaction();

        try
        {          
            var upravnik = upravnikDto.Map();

            Licenca licenca =await s.LoadAsync<Licenca>(licencaId);
            if (licenca == null)
            {
                return "Ne postoji licenca sa tim Id-jem";
            }
            upravnik.LicencaId = licenca;

            await s.SaveOrUpdateAsync(upravnik);
            
            transaction.Commit();

        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
            transaction.Rollback();
        }
        finally
        {
            await s.FlushAsync();
            s.Close();
        }
        return "Uspesno dodat upravnik";
    }//u upotrebi

    public async static Task<UpravnikBasic> IzmeniUpravnikaAsync(UpravnikBasic upravnik)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            Upravnik o = await (from u in s.Query<Upravnik>()
                                           where u.Id == upravnik.Id
                                           select u).FirstOrDefaultAsync();

            o.Ime = upravnik.Ime;
            o.ImeRoditelja = upravnik.ImeRoditelja;
            o.Prezime = upravnik.Prezime;
            o.DatumRodjenja = upravnik.DatumRodjenja;
            o.BrojLk = upravnik.BrojLk;
            o.MestoIzdavanja = upravnik.MestoIzdavanja;
            o.BrTel=upravnik.BrTel;
            o.Adresa=upravnik.Adresa;
            o.Institucija = upravnik.Institucija;
            o.Zvanje = upravnik.Zvanje;
            o.DatumSticanja = upravnik.DatumSticanja;

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();

        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return upravnik;
    }

    public static async Task obrisiUpravnika(string id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Upravnik o = await (from u in s.Query<Upravnik>()
                                            where u.Id == id
                                            select u).FirstOrDefaultAsync();

            s.Delete(o);
            s.Flush();

            s.Close();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async static Task<UpravnikPregled> VratiUpravnika(string idUpravnika)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            Upravnik upravnik = await (from o in s.Query<Upravnik>()
                                where o.Id == idUpravnika
                                select o).FirstOrDefaultAsync();

            var result = upravnik.Map1();

            return result;
        }
        catch (Exception e)
        {
            string error = e.Message;
            Console.WriteLine(error);
            return new UpravnikPregled();
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
    }

    #endregion
}
