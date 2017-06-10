using CarRentalSystem.Data;
using CarRentalSystem.Migrations;
using Microsoft.Owin;
using Owin;
using System.Data.Entity;

[assembly: OwinStartupAttribute(typeof(CarRentalSystem.Startup))]
namespace CarRentalSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<CarsDbContext, Configuration>());

            ConfigureAuth(app);
        }
    }
}
