using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using Projekat.Mapiranja;

namespace Projekat;

public class DataLayer
{
    private static ISessionFactory _factory = null;
    private static object objLock = new object();

    public static ISession GetSession()
    {
        //ukoliko session factory nije kreiran
        if (_factory == null)
        {
            lock (objLock)
            {
                if (_factory == null)
                    _factory = CreateSessionFactory();
            }
        }

        return _factory.OpenSession();
    } 

    //konfiguracija i kreiranje session factory
    private static ISessionFactory CreateSessionFactory()
    {
        try
        {
            var cfg = OracleManagedDataClientConfiguration.Oracle10
            .ShowSql()
            .ConnectionString(c =>
                c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB; PERSIST SECURITY INFO=True; USER ID=S18246; Password=Sreta#matic2001"));
            // Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=prodavnica;Password=prodavnica"

            return Fluently.Configure()
                .Database(cfg)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<AgencijaMapiranje>())              
                .BuildSessionFactory();
            //.ExposeConfiguration(BuildSchema)
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec.Message);                
        }
        return null!;
    }
}
