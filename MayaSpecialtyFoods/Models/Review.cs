using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MayaSpecialtyFoods.Models
{
    [Table("Reviews")]

    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string Author { get; set; }
        public string Content_Body { get; set; }
        public int Rating { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

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
