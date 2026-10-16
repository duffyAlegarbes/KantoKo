namespace KantoCart.Web.Models;

public enum ProductCategory
{
    TusokTusok,       // Street skewered foods
    CarinderiaUlam,   // Viands & Rice Meals
    MeriendaPalamig,  // Halo-halo, Turon, Sago't Gulaman
    SariSariDaily,    // Condiments, canned goods, rice
    AlmusalSilog      // Morning specials
}

public class ProductItem
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string LocalName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal? OriginalPrice { get; set; }
    public ProductCategory Category { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string VendorId { get; set; } = string.Empty;
    public string VendorName { get; set; } = string.Empty;
    public string UnitDisplay { get; set; } = "per order"; // e.g., "5 sticks", "per serving", "per pack"
    public string? BadgeText { get; set; }                 // e.g., "BAGONG LUTU", "BESTSELLER", "SUKI PICK"
    public bool IsAvailable { get; set; } = true;
    public bool IsWishlisted { get; set; } = false;
    public List<string> AvailableSauces { get; set; } = new(); // e.g., "Manong's Sweet", "Maanghang Suka"
}