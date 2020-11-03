using System.Data.Entity;

namespace PatientsRegistration
{
    public class RecordContext : DbContext
    {
        public RecordContext()
        : base("DefaultConnection")
        { }

        public DbSet<Record> Records { get; set; }
    }
}
