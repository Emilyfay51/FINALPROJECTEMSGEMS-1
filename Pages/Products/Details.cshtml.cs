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
    public class DetailsModel : PageModel
    {
        private readonly FinalProjectEmsGems_1.Models.AppDbContext _context;

        public DetailsModel(FinalProjectEmsGems_1.Models.AppDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; } = default!;
        public List<Review> Reviews { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.ProductID == id);
            if (product is null)
            {
                return NotFound();
            }
            Product = product;

            Reviews = await _context.Reviews
                .Where(r => r.ProductID == Product.ProductID)
                .ToListAsync();

            return Page();
        }
    }
}
