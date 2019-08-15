using System.Collections;
using System.Collections.Generic;

namespace Asp_Final.Models
{
    public class Make
    {
        public int Id { get; set; }

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        public ICollection<Car> Cars { get; set; }

    }
}