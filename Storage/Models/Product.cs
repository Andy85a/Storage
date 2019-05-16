using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {

        public int Id { get; set; }
        [StringLength (30, MinimumLength =1, ErrorMessage ="Name should be at least 1 character long")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Range(0,50000, ErrorMessage ="Price is out of range")]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        [Required(ErrorMessage ="Category{0} is required")]
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }

    }
}
