using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Final.Models
{
    public class Info
    {
        public int Id { get; set; }

        [Required]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        [Required]
        public DateTime CurrentDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}
