namespace Services.Products;

public record UpdateProductRequest(string Name, decimal Price, int Stock);