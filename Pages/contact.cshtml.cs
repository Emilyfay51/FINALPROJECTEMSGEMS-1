using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectEmsGems_1.Pages;

public class ContactModel : PageModel
{
    [BindProperty]
    [Required]
    public string Name { get; set; } = string.Empty;

    [BindProperty]
    [Required]
    public string Email { get; set; } = string.Empty;

    [BindProperty]
    [Required]
    public string Phone { get; set; } = string.Empty;

    [BindProperty]
    [Required]
    public string Address { get; set; } = string.Empty;

    [BindProperty]
    [Required]
    public string SuccessMessage { get; set; } = string.Empty;

public void OnGet()
{
    if(ModelState.IsValid)
    {
        SuccessMessage="Thank You for contacting us! We will get back to you shortly,";}
    }
}

