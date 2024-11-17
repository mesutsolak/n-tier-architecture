namespace Services.Products;

public interface IProductService
{
    Task<ServiceResult<List<ProductDto>>> GetTopPriceProductsAsync(int count);

    Task<ServiceResult<List<ProductDto>>> GetAllListAsync();

    Task<ServiceResult<ProductDto?>> GetByIdAsync(int id);

    Task<ServiceResult<CreateProductResponse>> CreateAsync(CreateProductRequest request);

    Task<ServiceResult> UpdateAsync(int id, UpdateProductRequest updateProductRequest);

    Task<ServiceResult> DeleteAsync(int id);

    Task<ServiceResult<List<ProductDto>>> GetPagedAllListAsync(int pageNumber, int pageSize);

    Task<ServiceResult> UpdateStockAsync(UpdateProductStockRequest request);
}
