using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        void DeleteProduct(Product product);
    }
}