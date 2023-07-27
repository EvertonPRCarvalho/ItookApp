namespace ItookApp.Domain.Products;
public class Product : Entity
{
    public string? Description { get; set; }
    public string CategoryId { get; set; }
    public bool HasStock { get; set; }
    public bool Active { get; set; } = true;

}

