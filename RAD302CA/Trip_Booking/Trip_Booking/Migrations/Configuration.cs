namespace Trip_booking.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Trip_booking.Models;
    using Trip_booking.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<TripContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TripContext context)
        {
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

            context.Trips.AddOrUpdate(
                t => t.ID,
                //new Trip { ID = 1, name = "Sahara Adventure", legs = 4, minimumGuests = 10 }
                new Trip { ID = 1, name = "Sahara Adventure", legs = 4, startDate = Convert.ToDateTime("2013/10/11"), endDate = Convert.ToDateTime("2013/10/21"), minimumGuests = 10 }
                //new Trip { ID = 2, name = "Sahara Adventure", legs = 4, startDate = Convert.ToDateTime("12/01/2013"), endDate = Convert.ToDateTime("12/02/2013"), minimumGuests = 10 },
                //new Trip { ID = 3, name = "Sahara Adventure", legs = 4, startDate = Convert.ToDateTime("12/01/2013"), endDate = Convert.ToDateTime("12/02/2013"), minimumGuests = 10 },
                //new Trip { ID = 4, name = "Sahara Adventure", legs = 4, startDate = Convert.ToDateTime("12/01/2013"), endDate = Convert.ToDateTime("12/02/2013"), minimumGuests = 10 }
        );

            context.Guests.AddOrUpdate(
                g => g.ID,
                new Guest { ID = 1, name = "Paddy", legs = 2 },
                new Guest { ID = 2, name = "Joe", legs = 1 },
                new Guest { ID = 3, name = "Mick", legs = 3 },
                new Guest { ID = 4, name = "Sean", legs = 5 },
                new Guest { ID = 5, name = "Jim", legs = 2 }
                );

            context.Legs.AddOrUpdate(
                l => l.ID,
                new Leg { ID=1}
                );

        }
    }
}
