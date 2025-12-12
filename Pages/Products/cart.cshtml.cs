using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FinalProjectEmsGems_1.Models;
using System.Text.Json;

// The CartItem class has been moved to Models/CartItem.cs

namespace FinalProjectEmsGems_1.Pages.Products
{
    public class CartModel : PageModel
    {
        public List<CartItem> CartItems { get; set; } = new();
        public decimal TotalAmount { get; set; }

        public void OnGet()
        {
            var cartJson = HttpContext.Session.GetString("Cart");
            if (!string.IsNullOrEmpty(cartJson))
            {
                CartItems = JsonSerializer.Deserialize<List<CartItem>>(cartJson) ?? new List<CartItem>();
            }
            TotalAmount = CartItems.Sum(item => item.Product.Price * item.Quantity);
        }

        public IActionResult OnPostRemoveItem(int productId)
        {
            var cartJson = HttpContext.Session.GetString("Cart");
            var cart = !string.IsNullOrEmpty(cartJson) ? JsonSerializer.Deserialize<List<CartItem>>(cartJson) ?? new List<CartItem>() : new List<CartItem>();
            var item = cart.FirstOrDefault(i => i.Product.ProductID == productId);
            if (item != null)
            {
                cart.Remove(item);
                HttpContext.Session.SetString("Cart", JsonSerializer.Serialize(cart));
            }
            return RedirectToPage();
        }

        public IActionResult OnPostCheckout()
        {
            // Implement checkout logic here
            HttpContext.Session.Remove("Cart");
            return RedirectToPage("Index");
        }
    }
}