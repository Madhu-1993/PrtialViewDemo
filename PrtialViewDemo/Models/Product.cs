using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrtialViewDemo.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        [ScaffoldColumn(false)]
        public int pid { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public int price { get; set; }
    }
}
