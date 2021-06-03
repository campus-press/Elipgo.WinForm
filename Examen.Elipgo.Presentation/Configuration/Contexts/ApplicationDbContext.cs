using Examen.Elipgo.Presentation.Configuration.DbEntities;
using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;

namespace Examen.Elipgo.Presentation.Configuration.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        static private string s_migrationSqlitePath;
        static ApplicationDbContext()
        {
            var exeDir = AppDomain.CurrentDomain.BaseDirectory;
            var exeDirInfo = new DirectoryInfo(exeDir);
            var projectDir = exeDirInfo.Parent.Parent.FullName;
            s_migrationSqlitePath = $@"{projectDir}\AppConfiguration.db";
        }

        public ApplicationDbContext() : base(new SQLiteConnection($"DATA Source={s_migrationSqlitePath}"), false)
        {

        }

        public ApplicationDbContext(DbConnection connection) : base(connection, true)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region ApplicationSettings

            modelBuilder.Entity<ApplicationSettings>()
                .Property(x => x.UrlConnectionRestAPI).HasColumnName("url_connection_rest_api")
                .HasMaxLength(60)
                .IsRequired();

            modelBuilder.Entity<ApplicationSettings>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<ApplicationSettings>()
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            #endregion

            #region Permissions

            modelBuilder.Entity<Permissions>()
                .Property(x => x.Type).HasColumnName("type")
                .HasMaxLength(50);

            modelBuilder.Entity<Permissions>()
                .Property(x => x.Value).HasColumnName("value")
                .HasMaxLength(50);

            modelBuilder.Entity<Permissions>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Permissions>()
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Permissions>()
                .HasRequired<User>(u => u.User)
                .WithMany(p => p.Permissions)
                .HasForeignKey<int>(u => u.UserId);

            #endregion

            #region Users

            modelBuilder.Entity<User>()
                .Property(x => x.UserName).HasColumnName("user_name")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(x => x.Email).HasColumnName("email")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(x => x.Roles).HasColumnName("roles")
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(x => x.Token).HasColumnName("token")
                .HasMaxLength(500);

            modelBuilder.Entity<User>()
                .Property(x => x.LastAccess)
                .HasColumnName("last_access");

            modelBuilder.Entity<User>()
                .Property(x => x.IsActiveSession)
                .HasColumnName("is_active_session");

            modelBuilder.Entity<User>()
                .Property(x => x.ExpirationToken)
                .HasColumnName("expiration_token");

            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<User>()
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            #endregion

        }

        public DbSet<ApplicationSettings> ApplicationSettings { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
