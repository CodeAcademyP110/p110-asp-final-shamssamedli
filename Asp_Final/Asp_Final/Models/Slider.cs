using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Asp_Final.Models
{
    public class Slider
    {
        public int Id { get; set; }


        [Required]
        public string Image { get; set; }

    }
}
