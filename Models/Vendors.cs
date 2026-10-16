namespace KantoCart.Web.Models;

public enum VendorType
{
    StreetFoodCart,    // Tusok-Tusok / Inihaw
    Carinderia,        // Cooked Viands / Ulam
    SariSariStore,     // Daily Packaged Goods & Sundries
    PalamigStand       // Refreshments & Desserts
}

public class Vendor
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public string Tagline { get; set; } = string.Empty;
    public VendorType Type { get; set; }
    public string Barangay { get; set; } = string.Empty;
    public double Rating { get; set; }
    public int TotalReviews { get; set; }
    public string EstimatedPrepTime { get; set; } = "10-15 mins";
    public bool IsSukiVerified { get; set; } = true;
    public string AvatarUrl { get; set; } = string.Empty;
}