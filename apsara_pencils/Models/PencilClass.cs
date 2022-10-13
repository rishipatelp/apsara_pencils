using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace apsara_pencils.Models
{
    public class PencilClass
    {
        public int ID { get; set; }
        public string productName { get; set; }
        public double Price { get; set; }
        public string Color  { get; set; }

        public string Category { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range (1,5)]
        public int Review { get; set; }
    }
}
