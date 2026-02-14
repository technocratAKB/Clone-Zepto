using Clone_Zepto.Extensions;
using Clone_Zepto.Models;
using Clone_Zepto.Services;
using Clone_Zepto.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Clone_Zepto.Controllers;

public sealed class CartController(CatalogService catalogService) : Controller
{
    private const string CartSessionKey = "cart";

    [HttpPost]
    public IActionResult Add(int productId)
    {
        var product = catalogService.GetById(productId);

        if (product is null)
        {
            return RedirectToAction("Index", "Home");
        }

        var cart = GetCart();
        var existingItem = cart.FirstOrDefault(item => item.Product.Id == productId);

        if (existingItem is null)
        {
            cart.Add(new CartItem { Product = product, Quantity = 1 });
        }
        else
        {
            existingItem.Quantity++;
        }

        SaveCart(cart);

        return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    public IActionResult UpdateQuantity(int productId, int quantity)
    {
        var cart = GetCart();
        var existingItem = cart.FirstOrDefault(item => item.Product.Id == productId);

        if (existingItem is not null)
        {
            if (quantity <= 0)
            {
                cart.Remove(existingItem);
            }
            else
            {
                existingItem.Quantity = quantity;
            }

            SaveCart(cart);
        }

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Index()
    {
        var model = new CartViewModel
        {
            Items = GetCart()
        };

        return View(model);
    }

    [HttpPost]
    public IActionResult Clear()
    {
        HttpContext.Session.Remove(CartSessionKey);
        return RedirectToAction(nameof(Index));
    }

    private List<CartItem> GetCart() => HttpContext.Session.GetFromJson<List<CartItem>>(CartSessionKey) ?? [];

    private void SaveCart(List<CartItem> cart) => HttpContext.Session.SetAsJson(CartSessionKey, cart);
}
