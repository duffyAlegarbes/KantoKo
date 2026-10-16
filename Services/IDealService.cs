using KantoCart.Web.Models;

namespace KantoCart.Web.Services;

public interface IDealService
{
    Task<DealOfTheDay> GetCurrentDealAsync();
}