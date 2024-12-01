namespace Repositories.Categories;

public interface ICategoryRepository : IGenericRepository<Category>
{
    Task<Category?> GetCategoryWithProductsAsync(int id);

    IQueryable<Category> GetCategoryWithProducts();
}