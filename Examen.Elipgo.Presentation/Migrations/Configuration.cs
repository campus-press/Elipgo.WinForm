using Examen.Elipgo.Presentation.Configuration.DbEntities;
using System.Data.SQLite.EF6.Migrations;

namespace Examen.Elipgo.Presentation.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Examen.Elipgo.Presentation.Configuration.Contexts.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(Examen.Elipgo.Presentation.Configuration.Contexts.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.ApplicationSettings.AddOrUpdate(new ApplicationSettings()
            {
                Id = 1,
                UrlConnectionRestAPI = "https://localhost:44302/",
                IsFirstExecution = true
            });
        }
    }
}
