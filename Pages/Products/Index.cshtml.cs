using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using FinalProjectEmsGems_1.Models;
namespace FinalProjectEmsGems_1.Pages_Products
{
public class IndexModel : PageModel
{
    [BindProperty(SupportsGet = true)]
    public int PageNum {get; set;} = 1;
    public int PageSize {get; set;} = 5;
    public int TotalPages {get; set;}

    // Sorting support
[BindProperty(SupportsGet = true)]
public string CurrentSort {get; set;} = string.Empty;
        private readonly FinalProjectEmsGems_1.Models.AppDbContext _context;

        // Search support
[BindProperty(SupportsGet = true)]
public string CurrentSearch {get; set;} = string.Empty;

        public IndexModel(FinalProjectEmsGems_1.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

public async Task OnGetAsync()
{
    var query = _context.Products.Include(p => p.Reviews).AsQueryable();
    if (!string.IsNullOrEmpty(CurrentSearch))
    {
        query = query.Where(p => p.Name.ToUpper().Contains(CurrentSearch.ToUpper()) || p.Description.ToUpper().Contains(CurrentSearch.ToUpper()));
    }

    switch (CurrentSort)
    {
        case "name_asc":
            query = query.OrderBy(p => p.Name);
            break;
        case "name_desc":
            query = query.OrderByDescending(p => p.Name);
            break;
        default:
            query = query.OrderBy(p => p.Name);
            break;
    }

    var totalCount = await query.CountAsync();
    TotalPages = (int)Math.Ceiling(totalCount / (double)PageSize);

    // Ensure PageNum is within valid range
    if (PageNum < 1) PageNum = 1;
    if (PageNum > TotalPages) PageNum = TotalPages;

    Product = await query
        .Skip((PageNum-1)*PageSize)
        .Take(PageSize)
        .ToListAsync();
}

// Add to Cart handler
public IActionResult OnPostAddToCart(int productId)
{
    var product = _context.Products.FirstOrDefault(p => p.ProductID == productId);
    if (product == null)
    {
        return RedirectToPage();
    }

    // Get cart from session
    var cartJson = HttpContext.Session.GetString("Cart");
    var cart = !string.IsNullOrEmpty(cartJson) ? System.Text.Json.JsonSerializer.Deserialize<List<CartItem>>(cartJson) ?? new List<CartItem>() : new List<CartItem>();

    var existingItem = cart.FirstOrDefault(i => i.Product.ProductID == productId);
    if (existingItem != null)
    {
        existingItem.Quantity++;
    }
    else
    {
        cart.Add(new CartItem { Product = product, Quantity = 1 });
    }

    HttpContext.Session.SetString("Cart", System.Text.Json.JsonSerializer.Serialize(cart));
    return RedirectToPage("/Products/cart");
}
    }
}
