using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColourAPI.Model
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<ColourContext>());
            }
        }
        public static void SeedData(ColourContext context)
        {
            Console.WriteLine("Applying Migrations....");
            context.Database.Migrate();
            if (!context.ColourItems.Any())
            {
                context.ColourItems.AddRange(
                    new Colour() { ColourName = "Red" }, new Colour() { ColourName = "Blue" }, new Colour() { ColourName = "Green" }, new Colour() { ColourName = "Yellow" }, new Colour() { ColourName = "Black" });
            }
            context.SaveChanges();
        }

    }
}
