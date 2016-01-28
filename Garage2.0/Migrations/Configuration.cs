namespace Garage2._0.Migrations
{

using Garage2._0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage2._0.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Garage2._0.Models.ApplicationDbContext";
        }

        protected override void Seed(Garage2._0.Models.ApplicationDbContext context)
        {
            var members = new List<Member> {
                new Member { 
                    FirstName="Carson",
                    LastName="Alexander"},
                new Member { 
                    FirstName="Lena",
                    LastName="Källgren"},
                new Member { 
                    FirstName="Rickard",
                    LastName="Nilsson"},
                new Member { 
                    FirstName="Per",
                    LastName="Söderberg"}
            };
            members.ForEach(m => context.Members.AddOrUpdate(M => M.LastName, m));
            context.SaveChanges();

            var vehicleTypes = new List<VehicleType> {
                new VehicleType { 
                    VehicleTypeId = 1,
                    TypeName = "Bil"},
                new VehicleType { 
                    VehicleTypeId = 2,
                    TypeName = "Båt"},
                new VehicleType { 
                    VehicleTypeId = 3,
                    TypeName = "Buss"},
                new VehicleType { 
                    VehicleTypeId = 4,
                    TypeName = "Flygplan"},
                new VehicleType { 
                    VehicleTypeId = 5,
                    TypeName = "Lastbil"},
                new VehicleType { 
                    VehicleTypeId = 6,
                    TypeName = "Motorcykel"}
            };
            vehicleTypes.ForEach(vt => context.VehicleTypes.AddOrUpdate(VT => VT.TypeName, vt));
            context.SaveChanges();

            var vehicles = new List<Vehicle> {
                new Vehicle { 
                    VehicleTypeId = 1,
                    RegistrationNumber = "ABC 123",
                    Colour = "Orange",
                    Brand = "Volvo",
                    Model = "Amason",
                    WheelCount = 4,
                    ParkTime = DateTime.Now,
                    ParkingLot = 1},
                new Vehicle { 
                    VehicleTypeId = 2,
                    RegistrationNumber = "CBS 123",
                    Colour = "Röd",
                    Brand = "Boeing",
                    Model = "767",
                    WheelCount = 12,
                    ParkTime = DateTime.Now,
                    ParkingLot = 2},
                new Vehicle { 
                    VehicleTypeId = 3,
                    RegistrationNumber = "Lena III",
                    Colour = "Vit",
                    Brand = "Star",
                    Model = "Princess",
                    WheelCount = 0,
                    ParkTime = DateTime.Now,
                    ParkingLot = 3},
                new Vehicle { 
                    VehicleTypeId = 4,
                    RegistrationNumber = "TTT 723",
                    Colour = "Black",
                    Brand = "HD",
                    Model = "Road Runner XXL",
                    WheelCount = 2,
                    ParkTime = DateTime.Now,
                    ParkingLot = 6}
            };

            vehicles.ForEach(v => context.Vehicles.AddOrUpdate(V => V.RegistrationNumber, v));
            context.SaveChanges();



  



        }
  
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
    }
}
