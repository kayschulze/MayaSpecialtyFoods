using System.Linq;

namespace MayaSpecialtyFoods.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        Product Save(Product product);
        Product Edit(Product product);
        void Remove(Product product);
    }
}