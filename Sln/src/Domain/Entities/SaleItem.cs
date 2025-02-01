using Domain.Common;

namespace Domain.Entities;

public class SaleItem : BaseEntity
{
    public Guid SaleId { get; set; }
    public required Sale Sale { get; set; }

    public required Guid ProductId { get; set; }
    public string ProductName { get; set; }

    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; private set; }
    public decimal TotalValue => Quantity * UnitPrice - Discount;

    public void ApplyDiscount()
    {
        if (Quantity >= 4 && Quantity < 10)
        {
            Discount = Quantity * UnitPrice * 0.10m; // 10% discount
        }
        else if (Quantity >= 10 && Quantity <= 20)
        {
            Discount = Quantity * UnitPrice * 0.20m; // 20% discount
        }
        else
        {
            Discount = 0;
        }
    }
}
