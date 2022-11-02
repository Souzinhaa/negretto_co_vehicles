namespace SeminarioP2
{
    using SeminarioP2.Classes;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Veiculos : DbContext
    {
        // Your context has been configured to use a 'Veiculos' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SeminarioP2.Veiculos' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Veiculos' 
        // connection string in the application configuration file.
        public Veiculos()
            : base("name=Veiculos")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        //public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Veiculo> VeiculoEntity { get; set; }
    }

}