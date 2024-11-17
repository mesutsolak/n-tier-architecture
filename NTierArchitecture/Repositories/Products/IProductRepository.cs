namespace Repositories.Products;

public interface IProductRepository : IGenericRepository<Product>
{
    Task<List<Product>> GetTopPriceProductsAsync(int count);
}
