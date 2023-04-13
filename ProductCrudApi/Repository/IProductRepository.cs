using ProductCrudApi.Models;

namespace ProductCrudApi.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(Guid id);
        Task<Product> CreateAsync(CreateProductRequest request);
    }
}
