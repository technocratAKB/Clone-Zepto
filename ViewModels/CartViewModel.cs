using Clone_Zepto.Models;

namespace Clone_Zepto.ViewModels;

public sealed class CartViewModel
{
    public required IReadOnlyList<CartItem> Items { get; init; }
    public decimal Subtotal => Items.Sum(item => item.LineTotal);
    public decimal DeliveryFee => Items.Count == 0 ? 0 : 25;
    public decimal GrandTotal => Subtotal + DeliveryFee;
}
