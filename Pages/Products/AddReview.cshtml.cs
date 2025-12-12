using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using FinalProjectEmsGems_1.Models;

namespace FinalProjectEmsGems_1.Pages.Products
{
    public class AddReviewModel : PageModel
    {
        private readonly AppDbContext _context;

        public AddReviewModel(AppDbContext context)
        {
            _context = context;
            Review = new ReviewInput();
            ProductList = new SelectList(_context.Products.ToList(), "ProductID", "Name");
        }

        [BindProperty]
        public ReviewInput Review { get; set; } = new ReviewInput();
        public SelectList ProductList { get; set; } = null!;

        public class ReviewInput
        {
            [Required]
            [Display(Name = "Product")]
            public int ProductID { get; set; }

            [Required]
            [Range(1, 5)]
            [Display(Name = "Score (1-5)")]
            public int Score { get; set; }

            [Required]
            [Display(Name = "Review Text")]
            public string ReviewText { get; set; } = string.Empty;
        }

        public void OnGet()
        {
            ProductList = new SelectList(_context.Products.ToList(), "ProductID", "Name");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ProductList = new SelectList(_context.Products.ToList(), "ProductID", "Name");
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var review = new Review
            {
                ProductID = Review.ProductID,
                Score = Review.Score,
                ReviewText = Review.ReviewText
            };
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
