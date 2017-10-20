using System.ComponentModel.DataAnnotations;
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

        public override bool Equals(System.Object otherProduct)
        {
            if (!(otherProduct is Product))
            {
                return false;
            }
            else
            {
                Product newProduct = (Product)otherProduct;
                return this.ProductId.Equals(newProduct.ProductId);
            }
        }

        public override int GetHashCode()
        {
            return this.ProductId.GetHashCode();
        }
    }
}
