using ezzyTickets.Data.Cart;
using Microsoft.AspNetCore.Mvc;

namespace ezzyTickets.Data.ViewComponents
{
    public class ShoppingCartSummary:ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var itemsCount = _shoppingCart.GetShoppingCartItemsCount();

            return View(itemsCount);
        }
    }
}
