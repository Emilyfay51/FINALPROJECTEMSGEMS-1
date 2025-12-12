using FinalProjectEmsGems_1.Models;

namespace FinalProjectEmsGems_1.Models
{
    public class CartItem
    {
        public Product Product { get; set; } = default!;
        public int Quantity { get; set; }
    }
}