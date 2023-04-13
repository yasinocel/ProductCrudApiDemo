using Microsoft.EntityFrameworkCore;
using ProductCrudApi.Data;
using ProductCrudApi.Models;

namespace ProductCrudApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;

        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }


        public async Task<Product> CreateAsync(CreateProductRequest request)
        {
            var product = Product.Create(request.Name, request.Description, request.Price);
            await _context.Products.AddAsync(product);
            _context.SaveChanges();
            return product;
        }

        public async Task<IEnumerable<Product>> GetAllAsync() => await _context.Products.ToListAsync();

        public async Task<Product?> GetByIdAsync(Guid id) => await _context.Products.FindAsync(id);

    }
}
