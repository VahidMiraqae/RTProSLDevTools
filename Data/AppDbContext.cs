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

        [DbFunction(IsBuiltIn = true)]
        public static int OdbcScale(byte? param1, byte? param2) => throw new InvalidOperationException();

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
                e.Property(a => a.ParameterId).HasColumnName("parameter_id");
                e.Property(a => a.UserTypeId).HasColumnName("user_type_id");
                e.Property(a => a.Scale).HasColumnName("scale");
                e.Property(a => a.IsOutput).HasColumnName("is_output");
                e.Property(a => a.IsCursorRef).HasColumnName("is_cursor_ref");
                e.Property(a => a.HasDefaultValue).HasColumnName("has_default_value");
                e.Property(a => a.IsXmlDocument).HasColumnName("is_xml_document");
                e.Property(a => a.DefaultValue).HasColumnName("default_value").HasColumnType("sql_varient")
                .HasConversion(v => 1, v => 2);
                e.Property(a => a.XmlCollectionId).HasColumnName("xml_collection_id");
                e.Property(a => a.IsReadonly).HasColumnName("is_readonly");
                e.Property(a => a.IsNullable).HasColumnName("is_nullable");
                e.Property(a => a.EncryptionType).HasColumnName("encryption_type");
                e.Property(a => a.EncryptionTypeDesc).HasColumnName("encryption_type_desc");
                e.Property(a => a.EncryptionAlgorithmName).HasColumnName("encryption_algorithm_name");
                e.Property(a => a.ColumnEncryptionKeyId).HasColumnName("column_encryption_key_id");
                e.Property(a => a.ColumnEncryptionKeyDatabaseName).HasColumnName("column_encryption_key_database_name");
                e.HasNoKey();
            });
        }
    }
}
