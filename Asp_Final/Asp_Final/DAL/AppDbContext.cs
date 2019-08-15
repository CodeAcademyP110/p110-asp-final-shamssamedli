using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Final.Models;



namespace Asp_Final.DAL
{
    public class CarSaleDbContext : DbContext
    {
        public CarSaleDbContext(DbContextOptions<CarSaleDbContext> options) : base(options){ }

        public DbSet<Slider> Sliders { get; set; }
        
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Make>Makes { get; set; }
        public DbSet<Transmission> Transmissions{ get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Info> Infos { get; set; }


    }
}
