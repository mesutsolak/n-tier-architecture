namespace Repositories.Products
{
    public interface IProductRepository
    {
        Task<List<Product>> GetTopPriceProductsAsync(int count);
    }
}
