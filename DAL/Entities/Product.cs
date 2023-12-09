using DAL.Entities.Enums;

namespace DAL.Entities;
public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;

    public UnitOfMeasure Measure { get; set; }

    public decimal PriceForUnit { get; set; }

    public int Quantity { get; set; }

    public DateTime UpdatedAt { get; set; }
}
