namespace KantoCart.Web.Models;

public class DealOfTheDay
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal SalePrice { get; set; }
    public decimal OriginalPrice { get; set; }
    public int AvailableStock { get; set; }
    public int TotalStock { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public DateTime EndsAt { get; set; }
    public List<string> BundleIncludes { get; set; } = new();
} 