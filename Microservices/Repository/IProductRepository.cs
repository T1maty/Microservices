using Microservices.Models;

namespace Microservices.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        IProductRepository GetProductByID(int ProductId);
        void InsertProduct(Product product);
        void DeleteProduct(int ProductId);
        void UpdateProduct(Product product);
        void Save();



    }
}
