namespace Repositories.Categories;

public class CategoryRepository(AppDbContext context) : GenericRepository<Category, int>(context), ICategoryRepository
{
    public IQueryable<Category> GetCategoryWithProducts()
    {
        return Context.Categories.Include(x => x.Products).AsQueryable();
    }

    public Task<Category?> GetCategoryWithProductsAsync(int id)
    {
        return Context.Categories.Include(x => x.Products).FirstOrDefaultAsync(x => x.Id == id);
    }
}
