using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Asp_Final.Models
{
    public class Car
    {

        public int Id { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int MakeId { get; set; }

        public virtual Make Make { get; set; }


        [Required]
        public string ProductYaer{ get; set; }

        [Required]
        public string Millage { get; set; }


        [Required, StringLength(200)]
        public string Color { get; set; }


        [Required]
        public int FuelTypeId { get; set; }

        public virtual FuelType FuelType { get; set; }

        public int TransmissionId { get; set; }
        public virtual Transmission Transmission { get; set; }

        public Info Info { get; set; }

    }
}
