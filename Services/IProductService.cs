using KantoCart.Web.Models;

namespace KantoCart.Web.Services;

public interface IProductService
{
    Task<List<ProductItem>> GetFeaturedProductsAsync();
    Task<List<ProductItem>> GetProductsByCategoryAsync(ProductCategory category);
    Task<ProductItem?> GetProductByIdAsync(string id);
    Task<List<Vendor>> GetFeaturedVendorsAsync();
}