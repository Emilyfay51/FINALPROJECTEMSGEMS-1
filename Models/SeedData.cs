using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectEmsGems_1.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        
 if (context.Products.Any()) 
        {
            return;
        }

       var products = new Product[]
{
    new Product { Name = "Emerald Ring", Description = "Radiant green emerald ring in a lustrous band, perfect for making every moment unforgettable.", Price = 250.00M, StockQuantity = 10, Category = "Rings", ImagePath = "/images/emeraldring.jpg" },
    new Product { Name = "Sapphire Necklace", Description = "A dazzling sapphire pendant gracefully suspended from a shimmering silver chain—timeless elegance for any occasion.", Price = 180.00M, StockQuantity = 5, Category = "Necklaces", ImagePath = "/images/sapphirenecklace.jpg" },
    new Product { Name = "Ruby Earrings", Description = "Brilliant ruby studs that catch the light and every eye in the room—pure sophistication in every sparkle.", Price = 120.00M, StockQuantity = 15, Category = "Earrings", ImagePath = "/images/rubyearrings.jpg" },
    new Product { Name = "Topaz Bracelet", Description = "Golden topaz stones set in a graceful bracelet, radiating warmth and luxury with every movement.", Price = 90.00M, StockQuantity = 20, Category = "Bracelets", ImagePath = "/images/topazbracelet.jpg" },
    new Product { Name = "Amethyst Pendant", Description = "A mesmerizing amethyst pendant on a gleaming silver chain—regal beauty for the modern muse.", Price = 75.00M, StockQuantity = 12, Category = "Necklaces", ImagePath = "/images/amethystpendant.jpg" },
    new Product { Name = "Diamond Ring", Description = "A classic diamond ring that dazzles with every glance—crafted for life’s most treasured moments.", Price = 500.00M, StockQuantity = 7, Category = "Rings", ImagePath = "/images/diamondring.jpg" },
    new Product { Name = "Pearl Necklace", Description = "Lustrous white pearls strung in timeless fashion—an heirloom piece for generations to cherish.", Price = 200.00M, StockQuantity = 8, Category = "Necklaces", ImagePath = "/images/pearlnecklace.jpg" },
    new Product { Name = "Opal Earrings", Description = "Iridescent opal earrings that shimmer with every color of the rainbow—enchanting and unique.", Price = 95.00M, StockQuantity = 14, Category = "Earrings", ImagePath = "/images/opalearrings.jpg" },
    new Product { Name = "Garnet Bracelet", Description = "Deep red garnets set in gold, this bracelet is a bold statement of passion and elegance.", Price = 85.00M, StockQuantity = 18, Category = "Bracelets", ImagePath = "/images/garnetbracelet.jpg" },
    new Product { Name = "Citrine Pendant", Description = "A sunlit citrine gemstone pendant, glowing with warmth and optimism on a delicate silver chain.", Price = 70.00M, StockQuantity = 10, Category = "Necklaces", ImagePath = "/images/citrinependant.jpg" },
    new Product { Name = "Aquamarine Ring", Description = "A serene aquamarine ring, reminiscent of tranquil seas—perfect for everyday elegance.", Price = 150.00M, StockQuantity = 6, Category = "Rings", ImagePath = "/images/aquamarinering.jpg" },
    new Product { Name = "Turquoise Necklace", Description = "Vivid turquoise beads strung on a supple leather cord—boho chic meets classic style.", Price = 65.00M, StockQuantity = 20, Category = "Necklaces", ImagePath = "/images/turquoisenecklace.jpg" },
    new Product { Name = "Onyx Earrings", Description = "Sleek black onyx studs, the epitome of understated glamour for any occasion.", Price = 55.00M, StockQuantity = 16, Category = "Earrings", ImagePath = "/images/onyxearrings.jpg" },
    new Product { Name = "Peridot Bracelet", Description = "Vibrant peridot gemstones in a playful bracelet—fresh, lively, and full of joy.", Price = 80.00M, StockQuantity = 12, Category = "Bracelets", ImagePath = "/images/peridotbracelet.jpg" },
    new Product { Name = "Spinel Pendant", Description = "A striking spinel pendant on silver, radiating depth and mystery with every glance.", Price = 95.00M, StockQuantity = 9, Category = "Necklaces", ImagePath = "/images/spinelpendant.jpg" },
    new Product { Name = "Blue Topaz Ring", Description = "Brilliant blue topaz set in a sleek silver band—modern, bold, and unforgettable.", Price = 140.00M, StockQuantity = 7, Category = "Rings", ImagePath = "/images/bluetopazring.jpg" },
    new Product { Name = "Moonstone Necklace", Description = "A mystical moonstone pendant that glows with ethereal light—dreamy and romantic.", Price = 75.00M, StockQuantity = 11, Category = "Necklaces", ImagePath = "/images/moonstonenecklace.jpg" },
    new Product { Name = "Lapis Earrings", Description = "Deep blue lapis lazuli earrings flecked with gold—regal and refined for any ensemble.", Price = 60.00M, StockQuantity = 14, Category = "Earrings", ImagePath = "/images/lapisearrings.jpg" },
    new Product { Name = "Chrysoberyl Bracelet", Description = "Golden chrysoberyl stones in a luxurious bracelet—rare beauty for the discerning collector.", Price = 110.00M, StockQuantity = 8, Category = "Bracelets", ImagePath = "/images/chrysoberylbracelet.jpg" },
    new Product { Name = "Tourmaline Pendant", Description = "A vibrant tourmaline pendant bursting with color—celebrate your individuality in style.", Price = 85.00M, StockQuantity = 10, Category = "Necklaces", ImagePath = "/images/tourmalinependant.jpg" },
    new Product { Name = "Jade Ring", Description = "Smooth green jade set in sterling silver—a symbol of harmony and prosperity.", Price = 130.00M, StockQuantity = 6, Category = "Rings", ImagePath = "/images/jadering.jpg" },
    new Product { Name = "Carnelian Necklace", Description = "Fiery orange carnelian beads, strung for energy and confidence—ignite your style.", Price = 50.00M, StockQuantity = 15, Category = "Necklaces", ImagePath = "/images/carneliannecklace.jpg" },
    new Product { Name = "Smoky Quartz Earrings", Description = "Elegant smoky quartz studs—earthy, mysterious, and effortlessly chic.", Price = 55.00M, StockQuantity = 12, Category = "Earrings", ImagePath = "/images/smokyquartzearrings.jpg" },
    new Product { Name = "Spinel Bracelet", Description = "Red spinel gemstones in a dazzling bracelet—vivid color and timeless design.", Price = 90.00M, StockQuantity = 10, Category = "Bracelets", ImagePath = "/images/spinelbracelet.jpg" },
    new Product { Name = "Garnet Pendant", Description = "A rich red garnet pendant on silver—passion and elegance in one unforgettable piece.", Price = 80.00M, StockQuantity = 9, Category = "Necklaces", ImagePath = "/images/garnetpendant.jpg" }
};

        context.Products.AddRange(products);
        context.SaveChanges();

        // Get products by name for review seeding
        var emeraldRing = context.Products.FirstOrDefault(p => p.Name.Contains("Emerald Ring"));
        var sapphireNecklace = context.Products.FirstOrDefault(p => p.Name.Contains("Sapphire Necklace"));
        var rubyEarrings = context.Products.FirstOrDefault(p => p.Name.Contains("Ruby Earrings"));
        var topazBracelet = context.Products.FirstOrDefault(p => p.Name.Contains("Topaz Bracelet"));
        var amethystPendant= context.Products.FirstOrDefault(p => p.Name.Contains("Amethyst Pendant"));
        var diamondRing = context.Products.FirstOrDefault(p => p.Name.Contains("Diamond Ring"));
        var pearlNecklace = context.Products.FirstOrDefault(p => p.Name.Contains("Pearl Necklace"));
        var opalEarrings= context.Products.FirstOrDefault(p => p.Name.Contains("Opal Earrings"));
        var garnetBracelet = context.Products.FirstOrDefault(p => p.Name.Contains("Garnet Bracelet"));
        var citrinePendant= context.Products.FirstOrDefault(p => p.Name.Contains("Citrine Pendant"));
        var aquamarineRing = context.Products.FirstOrDefault(p => p.Name.Contains("Aquamarine Ring"));
        var turquoiseNecklace = context.Products.FirstOrDefault(p => p.Name.Contains("Turquoise Necklace"));
        var onyxEarrings = context.Products.FirstOrDefault(p => p.Name.Contains("Onyx Earrings"));
        var peridotBracelet= context.Products.FirstOrDefault(p => p.Name.Contains("Peridot Bracelet"));
        var spinelPendant= context.Products.FirstOrDefault(p => p.Name.Contains("Spinel Pendant"));
        var bluetopazRing= context.Products.FirstOrDefault(p => p.Name.Contains("Blue Topaz Ring"));
        var moonstoneNecklace= context.Products.FirstOrDefault(p => p.Name.Contains("Moonstone Necklace"));
        var lapisEarrings = context.Products.FirstOrDefault(p => p.Name.Contains("Lapis Earrings"));
        var chrysoberylBracelet = context.Products.FirstOrDefault(p => p.Name.Contains("Chrysoberyl Bracelet"));
        var tourmalinePendant = context.Products.FirstOrDefault(p => p.Name.Contains("Tourmaline Pendant"));
        var jadeRing = context.Products.FirstOrDefault(p => p.Name.Contains("Jade Ring"));
        var carnelianNecklace = context.Products.FirstOrDefault(p => p.Name.Contains("Carnelian Necklace"));
        var smokyquartzEarrings= context.Products.FirstOrDefault(p => p.Name.Contains("Smoky Quartz Earrings"));
        var spinelBracelet = context.Products.FirstOrDefault(p => p.Name.Contains("Spinel Bracelet"));
        var garnetPendant = context.Products.FirstOrDefault(p => p.Name.Contains("Garnet Pendant"));
        // Only add reviews if all products are found
        if (emeraldRing == null || sapphireNecklace == null || rubyEarrings == null || topazBracelet == null || amethystPendant == null || diamondRing == null || pearlNecklace == null || opalEarrings == null || garnetBracelet == null || citrinePendant == null || aquamarineRing == null || turquoiseNecklace == null || onyxEarrings == null || peridotBracelet == null || spinelPendant == null || bluetopazRing == null || moonstoneNecklace == null || lapisEarrings == null || chrysoberylBracelet == null || tourmalinePendant == null || jadeRing == null || carnelianNecklace == null || smokyquartzEarrings == null || spinelBracelet == null || garnetPendant == null)
        {
            // Optionally, log or throw an exception here
            return;
        }

        context.Reviews.AddRange(
    // 1. Emerald Ring
    new Review { ProductID = emeraldRing!.ProductID, Score = 5, ReviewText = "The Emerald Ring is breathtaking! The green gemstone is vivid and the design is elegant. I get compliments every time I wear it." },
    new Review { ProductID = emeraldRing.ProductID, Score = 4, ReviewText = "Beautiful ring, though slightly smaller than I imagined. Still, a great piece of jewelry." },

    // 2. Sapphire Necklace
    new Review { ProductID = sapphireNecklace!.ProductID, Score = 5, ReviewText = "Stunning sapphire necklace! The deep blue stone really stands out. Very elegant and classy." },
    new Review { ProductID = sapphireNecklace.ProductID, Score = 3, ReviewText = "Lovely necklace, but the chain feels a bit delicate. Handle with care." },

    // 3. Ruby Earrings
    new Review { ProductID = rubyEarrings!.ProductID, Score = 5, ReviewText = "Sparkling ruby earrings! Perfect size and very comfortable to wear." },
    new Review { ProductID = rubyEarrings.ProductID, Score = 2, ReviewText = "One ruby was slightly chipped on arrival. Disappointed." },

    // 4. Topaz Bracelet
    new Review { ProductID = topazBracelet!.ProductID, Score = 4, ReviewText = "Golden topaz bracelet is elegant and eye-catching. Lightweight but beautiful." },
    new Review { ProductID = topazBracelet.ProductID, Score = 5, ReviewText = "Absolutely love this bracelet! Goes with everything." },

    // 5. Amethyst Pendant
    new Review { ProductID = amethystPendant!.ProductID, Score = 5, ReviewText = "The amethyst pendant is gorgeous and the color is rich. Very happy with it." },
    new Review { ProductID = amethystPendant.ProductID, Score = 3, ReviewText = "Nice pendant, but the chain feels fragile." },

    // 6. Diamond Ring
    new Review { ProductID = diamondRing!.ProductID, Score = 5, ReviewText = "Classic diamond ring! Sparkles brilliantly and fits perfectly. A timeless piece." },
    new Review { ProductID = diamondRing.ProductID, Score = 4, ReviewText = "Beautiful ring, though I expected a slightly larger diamond." },

    // 7. Pearl Necklace
    new Review { ProductID = pearlNecklace!.ProductID, Score = 5, ReviewText = "Elegant pearl necklace. Pearls are lustrous and the clasp is secure." },
    new Review { ProductID = pearlNecklace.ProductID, Score = 4, ReviewText = "Lovely necklace, though one pearl is slightly smaller than the others." },

    // 8. Opal Earrings
    new Review { ProductID = opalEarrings!.ProductID, Score = 5, ReviewText = "Opal earrings are stunning! The iridescent colors catch the light beautifully." },
    new Review { ProductID = opalEarrings.ProductID, Score = 3, ReviewText = "Pretty earrings, but they feel delicate." },

    // 9. Garnet Bracelet
    new Review { ProductID = garnetBracelet!.ProductID, Score = 5, ReviewText = "Red garnet bracelet is gorgeous and comfortable to wear." },
    new Review { ProductID = garnetBracelet.ProductID, Score = 4, ReviewText = "Beautiful bracelet, though the clasp is a bit tricky." },

    // 10. Citrine Pendant
    new Review { ProductID = citrinePendant!.ProductID, Score = 5, ReviewText = "Citrine pendant is bright and cheerful! The silver chain complements the stone perfectly." },
    new Review { ProductID = citrinePendant.ProductID, Score = 3, ReviewText = "Nice pendant, but smaller than I expected." },

    // 11. Aquamarine Ring
    new Review { ProductID = aquamarineRing!.ProductID, Score = 5, ReviewText = "Delicate aquamarine ring, perfect for everyday wear. Stone sparkles beautifully." },
    new Review { ProductID = aquamarineRing.ProductID, Score = 4, ReviewText = "Very pretty ring, though I wish the band was slightly thicker." },

    // 12. Turquoise Necklace
    new Review { ProductID = turquoiseNecklace!.ProductID, Score = 5, ReviewText = "Vibrant turquoise necklace! Leather cord is comfortable and adds a casual style." },
    new Review { ProductID = turquoiseNecklace.ProductID, Score = 3, ReviewText = "Beautiful necklace but the leather cord could be sturdier." },

    // 13. Onyx Earrings
    new Review { ProductID = onyxEarrings!.ProductID, Score = 4, ReviewText = "Black onyx earrings are elegant and versatile. Nice for both casual and formal wear." },
    new Review { ProductID = onyxEarrings.ProductID, Score = 2, ReviewText = "One earring arrived slightly loose. Needed adjustment." },

    // 14. Peridot Bracelet
    new Review { ProductID = peridotBracelet!.ProductID, Score = 5, ReviewText = "Bright peridot bracelet looks amazing. Stones are vibrant and comfortable to wear." },
    new Review { ProductID = peridotBracelet.ProductID, Score = 4, ReviewText = "Lovely bracelet, though the clasp feels a bit flimsy." },

    // 15. Spinel Pendant
    new Review { ProductID = spinelPendant!.ProductID, Score = 5, ReviewText = "Spinel pendant is gorgeous! The color is deep and eye-catching." },
    new Review { ProductID = spinelPendant.ProductID, Score = 3, ReviewText = "Beautiful pendant, but smaller than expected." },

    // 16. Blue Topaz Ring
    new Review { ProductID = bluetopazRing!.ProductID, Score = 5, ReviewText = "Blue Topaz Ring is stunning and delicate. Perfect for everyday elegance." },
    new Review { ProductID = bluetopazRing.ProductID, Score = 4, ReviewText = "Pretty ring, though the stone could be slightly bigger." },

    // 17. Moonstone Necklace
    new Review { ProductID = moonstoneNecklace!.ProductID, Score = 5, ReviewText = "Moonstone pendant necklace is lovely. Stone catches the light beautifully." },
    new Review { ProductID = moonstoneNecklace.ProductID, Score = 3, ReviewText = "Nice necklace, but the chain feels light and delicate." },

    // 18. Lapis Earrings
    new Review { ProductID = lapisEarrings!.ProductID, Score = 5, ReviewText = "Deep blue lapis earrings are gorgeous. Great for casual or formal wear." },
    new Review { ProductID = lapisEarrings.ProductID, Score = 4, ReviewText = "Pretty earrings, though the blue is slightly darker than in the photos." },

    // 19. Chrysoberyl Bracelet
    new Review { ProductID = chrysoberylBracelet!.ProductID, Score = 5, ReviewText = "Chrysoberyl bracelet is elegant and comfortable. Gold chain adds a luxurious touch." },
    new Review { ProductID = chrysoberylBracelet.ProductID, Score = 4, ReviewText = "Lovely bracelet, though the clasp is a little tricky." },

    // 20. Tourmaline Pendant
    new Review { ProductID = tourmalinePendant!.ProductID, Score = 5, ReviewText = "Colorful tourmaline pendant is vibrant and unique. Really stands out." },
    new Review { ProductID = tourmalinePendant.ProductID, Score = 3, ReviewText = "Beautiful pendant, but smaller than I expected." },

    // 21. Jade Ring
    new Review { ProductID = jadeRing!.ProductID, Score = 5, ReviewText = "Green jade ring is elegant and well-crafted. Comfortable to wear daily." },
    new Review { ProductID = jadeRing.ProductID, Score = 4, ReviewText = "Lovely ring, though the band feels slightly thin." },

    // 22. Carnelian Necklace
    new Review { ProductID = carnelianNecklace!.ProductID, Score = 5, ReviewText = "Orange carnelian necklace is cheerful and stylish. Great for layering with other necklaces." },
    new Review { ProductID = carnelianNecklace.ProductID, Score = 3, ReviewText = "Pretty necklace, but the beads are slightly smaller than expected." },

    // 23. Smoky Quartz Earrings
    new Review { ProductID = smokyquartzEarrings!.ProductID, Score = 5, ReviewText = "Smoky quartz earrings are elegant and versatile. Perfect for daily wear or special occasions." },
    new Review { ProductID = smokyquartzEarrings.ProductID, Score = 4, ReviewText = "Nice earrings, though one stone was slightly off-center." },

    // 24. Spinel Bracelet
    new Review { ProductID = spinelBracelet!.ProductID, Score = 5, ReviewText = "Red spinel bracelet is vibrant and fits comfortably. Looks beautiful on the wrist." },
    new Review { ProductID = spinelBracelet.ProductID, Score = 3, ReviewText = "Pretty bracelet, but the clasp is tricky to fasten." },

    // 25. Garnet Pendant
    new Review { ProductID = garnetPendant!.ProductID, Score = 5, ReviewText = "Garnet pendant is stunning. Rich red color and elegant silver chain." },
    new Review { ProductID = garnetPendant.ProductID, Score = 4, ReviewText = "Beautiful pendant, though smaller than expected." }
);


        context.SaveChanges();
    }
       

    }