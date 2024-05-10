using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParkingSystem.Models;

namespace ParkingSystem.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        //dum data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, Mark = "Opel", Plate = "P5467BH" },
                new Car { Id = 2, Mark = "Nisan", Plate = "P5467BH" },
                new Car { Id = 3, Mark = "BMW", Plate = "P5467BH" }
            );
        }
    }
}