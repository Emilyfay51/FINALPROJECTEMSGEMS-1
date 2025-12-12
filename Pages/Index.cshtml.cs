using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProjectEmsGems_1.Models;

namespace FinalProjectEmsGems_1.Pages;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;
    public int TotalPages { get; set; }
    public int PageSize { get; set; } = 10;
    public int PageNum { get; set; } = 1;
    public string CurrentSort { get; set; } = "";
    public IList<Product> Product { get; set; } = default!;


    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public async Task OnGetAsync()
    {
        var query = _context.Products.AsQueryable();

        switch (CurrentSort)
        {
            case "first_asc":
                query = query.OrderBy(p => p.Name);
                break;
            case "first_desc":
                query = query.OrderByDescending(p => p.Name);
                break;
            default:
                query = query.OrderBy(p => p.Name);
                break;
        }

        TotalPages = (int)Math.Ceiling(await query.CountAsync() / (double)PageSize);
        Product = await query
            .Include(p => p.Reviews)
            .Skip((PageNum-1)*PageSize)
            .Take(PageSize)
            .ToListAsync();
    }
}
