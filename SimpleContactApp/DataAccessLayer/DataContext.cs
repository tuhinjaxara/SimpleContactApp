
namespace SimpleContactApp.DataAccessLayer
{
    using System.Data.Entity;
    using Models;

    public class DataContext : DbContext
    {

        public DataContext() : base("DefaultConnection")
        {
            Database.SetInitializer<DataContext>
                (new DropCreateDatabaseIfModelChanges<DataContext>());
        }
        
        public DbSet<Contact> Contacts { get; set; }

    }

    
}