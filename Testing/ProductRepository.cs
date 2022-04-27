using Dapper;
using System.Collections.Generic;
using System.Data;
using Testing.Models;

namespace Testing
{
    public class ProductRepository : IProductRepository 
    {
        private readonly IDbConnection_ conn;
        private object return_conn;
        private IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;

        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM products");
        }
    }
}
