namespace WebApiTemplate.Api
{
    using System.Data.Entity;
    using WebApiTemplate.Data;
    using WebApiTemplate.Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WebApiTemplateDbContext, Configuration>());
            WebApiTemplateDbContext.Create().Database.Initialize(true);
        }
    }
}