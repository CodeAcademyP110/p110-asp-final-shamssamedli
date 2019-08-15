using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Final.Models
{
    public class AddView
    {
        public List<Brand> Brands { get; set; }

        public List<FuelType> FuelTypes { get; set; }

        public List<Car> Cars { get; set; }

        public List<Transmission> Transmissions { get; set; }

        public List<Make> Makes { get; set; }
        public List<Country> Countries { get; set; }
        public List<City> Cities { get; set; }
    }
}
