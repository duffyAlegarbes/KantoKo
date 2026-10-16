namespace KantoCart.Web.Models;

public class CartItem
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public ProductItem Product { get; set; } = new();
    public int Quantity { get; set; } = 1;
    public string SelectedSauce { get; set; } = "Default";
    public string SpecialNotes { get; set; } = string.Empty;

    public decimal Subtotal => Product.Price * Quantity;
}