using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDotNetCoreFake.Models
{
    public class RentACarDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public RentACarDbContext()
        {

        }

        public RentACarDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
