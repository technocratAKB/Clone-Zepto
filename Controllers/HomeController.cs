using Clone_Zepto.Extensions;
using Clone_Zepto.Models;
using Clone_Zepto.Services;
using Clone_Zepto.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Clone_Zepto.Controllers;

public sealed class HomeController(CatalogService catalogService) : Controller
{
    private const string CartSessionKey = "cart";

    public IActionResult Index(string? category)
    {
        var allProducts = catalogService.GetAll();
        var categories = allProducts
            .Select(product => product.Category)
            .Distinct()
            .OrderBy(categoryName => categoryName)
            .ToList();

        var filteredProducts = string.IsNullOrWhiteSpace(category)
            ? allProducts
            : allProducts.Where(product => product.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();

        var cart = HttpContext.Session.GetFromJson<List<CartItem>>(CartSessionKey) ?? [];

        var model = new HomeViewModel
        {
            Products = filteredProducts,
            Categories = categories,
            ActiveCategory = category,
            CartCount = cart.Sum(item => item.Quantity)
        };

        return View(model);
    }
}
