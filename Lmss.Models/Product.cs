using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lmss.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please Enter Price")]
        public double Price { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
    }
}
