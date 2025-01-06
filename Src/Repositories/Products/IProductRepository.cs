namespace Repositories.Products;

public interface IProductRepository : IGenericRepository<Product, int>
{
    Task<List<Product>> GetTopPriceProductsAsync(int count);
}
