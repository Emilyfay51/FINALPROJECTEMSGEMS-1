using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProjectEmsGems_1.Models;

namespace FinalProjectEmsGems_1.Pages_Products;

public class EditReviewModel : PageModel
{
    private readonly AppDbContext _context;
    [BindProperty]
    public Review Review { get; set; } = default!;

    public EditReviewModel(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        Review = await _context.Reviews.FirstOrDefaultAsync(r => r.ReviewID == id);
        if (Review == null)
        {
            return NotFound();
        }
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        var reviewInDb = await _context.Reviews.FindAsync(Review.ReviewID);
        if (reviewInDb == null)
        {
            return NotFound();
        }
        reviewInDb.Score = Review.Score;
        reviewInDb.ReviewText = Review.ReviewText;
        await _context.SaveChangesAsync();
        return RedirectToPage("Details", new { id = reviewInDb.ProductID });
    }
}
