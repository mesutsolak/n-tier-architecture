namespace Services.Products.Create;

public record CreateProductRequest(string Name, decimal Price, int Stock);