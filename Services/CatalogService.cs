using Clone_Zepto.Models;

namespace Clone_Zepto.Services;

public sealed class CatalogService
{
    private static readonly IReadOnlyList<Product> Products =
    [
        new() { Id = 1, Name = "Fresh Bananas", Category = "Fruits", Unit = "1 kg", Price = 49, Badge = "9 min", Emoji = "🍌" },
        new() { Id = 2, Name = "Farm Eggs", Category = "Dairy", Unit = "12 pcs", Price = 92, Badge = "12 min", Emoji = "🥚" },
        new() { Id = 3, Name = "Aashirvaad Atta", Category = "Staples", Unit = "5 kg", Price = 259, Badge = "15 min", Emoji = "🌾" },
        new() { Id = 4, Name = "Amul Butter", Category = "Dairy", Unit = "500 g", Price = 285, Badge = "11 min", Emoji = "🧈" },
        new() { Id = 5, Name = "Tomatoes", Category = "Vegetables", Unit = "1 kg", Price = 42, Badge = "8 min", Emoji = "🍅" },
        new() { Id = 6, Name = "Potato Chips", Category = "Snacks", Unit = "150 g", Price = 35, Badge = "10 min", Emoji = "🥔" },
        new() { Id = 7, Name = "Coca-Cola", Category = "Beverages", Unit = "750 ml", Price = 40, Badge = "7 min", Emoji = "🥤" },
        new() { Id = 8, Name = "Dark Chocolate", Category = "Snacks", Unit = "100 g", Price = 110, Badge = "13 min", Emoji = "🍫" }
    ];

    public IReadOnlyList<Product> GetAll() => Products;

    public Product? GetById(int id) => Products.FirstOrDefault(product => product.Id == id);
}
