namespace Repositories.Products;

public class ProductRepository(AppDbContext context) : GenericRepository<Product>(context), IProductRepository
{
    public Task<List<Product>> GetTopPriceProductsAsync(int count) => Context.Products.OrderByDescending(p => p.Price).Take(count).ToListAsync();
}
