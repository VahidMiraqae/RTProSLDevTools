using Microsoft.EntityFrameworkCore;
using RTProSLDevTools.Models;

namespace RTProSLDevTools.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        [DbFunction(IsBuiltIn = true)]
        public static int OdbcPrec(byte param1, short param2, byte param3) => throw new InvalidOperationException();

        [DbFunction(IsBuiltIn = true)]
        public static int OBJECT_ID(string object_name) => throw new InvalidOperationException();

        [DbFunction(IsBuiltIn = true)]
        public static string TYPE_NAME(int object_id) => throw new InvalidOperationException();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpParameter>(e =>
            {
                e.ToView("parameters", "sys");
                e.Property(a => a.Name).HasColumnName("name");
                e.Property(a => a.ObjectId).HasColumnName("object_id");
                e.Property(a => a.MaxLength).HasColumnName("max_length");
                e.Property(a => a.SystemTypeId).HasColumnName("system_type_id");
                e.Property(a => a.Precision).HasColumnName("precision");
                e.HasNoKey();
            });
        }
    }
}
