using Clone_Zepto.Models;

namespace Clone_Zepto.ViewModels;

public sealed class HomeViewModel
{
    public required IReadOnlyList<Product> Products { get; init; }
    public required IReadOnlyList<string> Categories { get; init; }
    public string? ActiveCategory { get; init; }
    public int CartCount { get; init; }
}
