﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Final.Models
{
    public class Brand

    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }

        public ICollection<Make> Makes { get; set; }
    }
}
