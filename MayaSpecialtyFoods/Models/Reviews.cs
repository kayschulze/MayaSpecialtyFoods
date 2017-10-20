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
        public virtual Product ProductId { get; set; }
    }
}
