namespace Clone_Zepto.Models;

public sealed class Product
{
    public required int Id { get; init; }
    public required string Name { get; init; }
    public required string Category { get; init; }
    public required string Unit { get; init; }
    public required decimal Price { get; init; }
    public required string Badge { get; init; }
    public required string Emoji { get; init; }
}
