namespace CarRentalSystem.Migrations
{
    using Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<CarRentalSystem.Data.CarsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "CarRentalSystem.Data.CarsDbContext";
        }

        protected override void Seed(CarRentalSystem.Data.CarsDbContext context)
        {
            if (context.Cars.Any())
            {
                return;
            }

            var user = context.Users.FirstOrDefault();

            if (user == null)
            {
                return;
            }

            context.Cars.Add(new Car
            {
                Make = "BMW",
                Model = "650i",
                Color = "Black",
                Engine = 5.0,
                EngineType = EngineType.Gasoline,
                ImageUrl = "https://s-media-cache-ak0.pinimg.com/originals/d8/3a/63/d83a636b0005231d920b73af45035699.jpg",
                Power = 5000,
                PricePerDay = 5000,
                Year = 2016,
                OwnerId = user.Id
            });
            context.Cars.Add(new Car
            {
                Make = "BMW",
                Model = "640i",
                Color = "White",
                Engine = 3.0,
                EngineType = EngineType.Gasoline,
                ImageUrl = "https://s-media-cache-ak0.pinimg.com/originals/d8/3a/63/d83a636b0005231d920b73af45035699.jpg",
                Power = 600,
                PricePerDay = 35,
                Year = 2017,
                OwnerId = user.Id
            });          
            context.Cars.Add(new Car
            {
                Make = "Mercedes",
                Model = "S550",
                Color = "White",
                Engine = 4.0,
                EngineType = EngineType.Gasoline,
                ImageUrl = "https://s-media-cache-ak0.pinimg.com/736x/71/1e/81/711e81774d002d109fe98441b6257717.jpg",
                Power = 450,
                PricePerDay = 240,
                Year = 2015,
                OwnerId = user.Id
            });               
        }
    }
}
