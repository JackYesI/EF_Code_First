using System.Data.Entity;
using System.Linq;

namespace CodeFIRST
{
    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFIRST.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1_Db_")
        {
        }

        public virtual DbSet<Airplanes> Airplane { get; set; }
        public virtual DbSet<Clients> Client { get; set; }
        public virtual DbSet<Flights> Flight { get; set; }
        public virtual DbSet<Accounts> Account { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}