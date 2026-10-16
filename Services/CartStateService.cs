using KantoCart.Web.Models;

namespace KantoCart.Web.Services;

public class CartStateService
{
    private readonly List<CartItem> _items = new();

    public IReadOnlyList<CartItem> Items => _items.AsReadOnly();
    public int TotalItemCount => _items.Sum(i => i.Quantity);
    public decimal Subtotal => _items.Sum(i => i.Subtotal);

    // Free delivery threshold: ₱199
    public const decimal FreeDeliveryThreshold = 199.00m;
    public const decimal StandardDeliveryFee = 39.00m;

    public decimal DeliveryFee => Subtotal >= FreeDeliveryThreshold || Subtotal == 0 ? 0.00m : StandardDeliveryFee;
    public decimal AmountNeededForFreeDelivery => Math.Max(0, FreeDeliveryThreshold - Subtotal);

    // Voucher state
    public string? AppliedVoucherCode { get; private set; }
    public decimal DiscountAmount { get; private set; } = 0.00m;
    public decimal GrandTotal => Math.Max(0, Subtotal + DeliveryFee - DiscountAmount);

    // Drawer and Modal Visibility States
    public bool IsCartOpen { get; private set; } = false;
    public bool IsCheckoutOpen { get; private set; } = false;
    public bool IsTrackerOpen { get; private set; } = false;

    public event Action? OnChange;

    public void OpenCart()
    {
        IsCartOpen = true;
        NotifyStateChanged();
    }

    public void CloseCart()
    {
        IsCartOpen = false;
        NotifyStateChanged();
    }

    public void ToggleCart()
    {
        IsCartOpen = !IsCartOpen;
        NotifyStateChanged();
    }

    public void OpenCheckout()
    {
        IsCartOpen = false;
        IsCheckoutOpen = true;
        NotifyStateChanged();
    }

    public void CloseCheckout()
    {
        IsCheckoutOpen = false;
        NotifyStateChanged();
    }

    public void OpenTracker()
    {
        IsCheckoutOpen = false;
        IsTrackerOpen = true;
        NotifyStateChanged();
    }

    public void CloseTracker()
    {
        IsTrackerOpen = false;
        NotifyStateChanged();
    }

    public void AddItem(ProductItem product, int quantity = 1, string sauce = "Default")
    {
        var existing = _items.FirstOrDefault(i => i.Product.Id == product.Id && i.SelectedSauce == sauce);
        if (existing != null)
        {
            existing.Quantity += quantity;
        }
        else
        {
            _items.Add(new CartItem
            {
                Product = product,
                Quantity = quantity,
                SelectedSauce = sauce
            });
        }
        RecalculateVoucher();
        NotifyStateChanged();
    }

    public void RemoveItem(string cartItemId)
    {
        _items.RemoveAll(i => i.Id == cartItemId);
        RecalculateVoucher();
        NotifyStateChanged();
    }

    public void UpdateQuantity(string cartItemId, int newQty)
    {
        var item = _items.FirstOrDefault(i => i.Id == cartItemId);
        if (item == null) return;

        if (newQty <= 0)
        {
            _items.Remove(item);
        }
        else
        {
            item.Quantity = newQty;
        }
        RecalculateVoucher();
        NotifyStateChanged();
    }

    public void UpdateSauce(string cartItemId, string sauce)
    {
        var item = _items.FirstOrDefault(i => i.Id == cartItemId);
        if (item != null)
        {
            item.SelectedSauce = sauce;
            NotifyStateChanged();
        }
    }

    public bool ApplyVoucher(string code)
    {
        if (string.Equals(code.Trim(), "KANTO10", StringComparison.OrdinalIgnoreCase))
        {
            AppliedVoucherCode = "KANTO10";
            DiscountAmount = Math.Round(Subtotal * 0.10m, 2);
            NotifyStateChanged();
            return true;
        }
        return false;
    }

    public void RemoveVoucher()
    {
        AppliedVoucherCode = null;
        DiscountAmount = 0.00m;
        NotifyStateChanged();
    }

    public void ClearCart()
    {
        _items.Clear();
        AppliedVoucherCode = null;
        DiscountAmount = 0.00m;
        NotifyStateChanged();
    }

    private void RecalculateVoucher()
    {
        if (AppliedVoucherCode == "KANTO10")
        {
            DiscountAmount = Math.Round(Subtotal * 0.10m, 2);
        }
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}