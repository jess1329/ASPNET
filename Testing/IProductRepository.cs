using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product); 
        {
         _conn.Execute("UPDATE products SET Name = @name, Price = @price WHERE ProductID = @id",
     new {name = product.Name, price = product.Price, id = product.ProductID });


        }
    }
}
