using ezzyTickets.Data.Cart;

namespace ezzyTickets.Data.ViewModels
{
    public class ShoppingCartVM
    {
        public ShoppingCart ShoppingCart { get; set; } = null!;
        public double ShoppingCartTotal { get; set; }
    }
} 