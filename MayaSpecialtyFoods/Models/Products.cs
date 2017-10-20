using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MayaSpecialtyFoods.Models
{
    [Table("Products")]

    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public float Origincountry { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
