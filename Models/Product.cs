using System.ComponentModel.DataAnnotations;

namespace FinalProjectEmsGems_1.Models;

public class Product
{
    public int ProductID {get; set;}
    public string Name {get; set;} = string.Empty;
    public string Description {get;set;} = string.Empty;
    public string Category {get; set;} = string.Empty;
    public decimal Price {get; set;}
    public string ImagePath {get; set;} = string.Empty;
    public int StockQuantity {get; set;}

    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}
public class ProductReview
{
    public int ProductID { get; set; }
    public Product Product { get; set; } = null!;

    public int ReviewID { get; set; }
    public Review Review { get; set; } = null!;
}