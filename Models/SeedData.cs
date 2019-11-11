using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDotNetCoreFake.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RentACarDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RentACarDbContext>>()))
            {
                if (context.Cars.Any())
                {
                    return;  
                }

                context.Cars.AddRange(
                    new Car() { Age = 2012, Brand = "Renault", Model = "Logan" },
                    new Car() { Age = 2003, Brand = "Toyota", Model = "Corolla" },
                    new Car() { Age = 2003, Brand = "Fiat", Model = "Palio" }
                );

                context.SaveChanges();
            }
        }
    }
}
