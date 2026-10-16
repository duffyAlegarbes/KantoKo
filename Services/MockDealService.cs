using KantoCart.Web.Models;

namespace KantoCart.Web.Services;

public class MockDealService : IDealService
{
    public Task<DealOfTheDay> GetCurrentDealAsync()
    {
        var deal = new DealOfTheDay
        {
            Id = "DEAL-BARKADA-01",
            Title = "Barkada Kanto Fiesta Box",
            Subtitle = "Merienda Rush • Flash Sulit Deal",
            Description = "Ultimate combo: 12 pcs Crispy Kwek-Kwek, 8 Sticks Pork Isaw, 10 pcs Fishball & Squidball combo, plus 1.5L Gulaman.",
            SalePrice = 189.00m,
            OriginalPrice = 315.00m,
            AvailableStock = 8,
            TotalStock = 25,
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTE-nqFf-Pn4Af-aTpPfQjkI4EeABY7gvb6Db6ea8986w&s=10",
            EndsAt = DateTime.UtcNow.AddHours(4).AddMinutes(32),
            BundleIncludes = new()
            {
                "12x Tokneneng Kwek-Kwek",
                "8x Inihaw Pork Isaw",
                "10x Fishball/Squidball mix",
                "Free 1.5L Sago't Gulaman"
            }
        };

        return Task.FromResult(deal);
    }
}