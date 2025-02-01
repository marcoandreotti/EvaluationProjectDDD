using Domain.Common;
using Domain.Events;

namespace Domain.Entities;

public class Sale : BaseEntity
{
    public long SaleNumber { get; set; }
    public DateTime SaleDate { get; set; }

    public Guid CustomerId { get; set; }
    public string CustomerName { get; set; }

    public decimal TotalValue { get; private set; }

    public Guid BranchId { get; set; }
    public string BranchName { get; set; }

    public List<SaleItem> Items { get; set; }
    public bool IsCancelled { get; private set; }

    public Sale()
    {
        Items = new List<SaleItem>();
        IsCancelled = false;
    }

    public void AddItem(SaleItem item)
    {
        // Check the item quantity limit
        if (item.Quantity > 20)
            throw new InvalidOperationException("Cannot sell more than 20 identical items.");

        // Add the item to the sale
        Items.Add(item);
        UpdateTotalValue();
    }

    public void Cancel()
    {
        if (!IsCancelled)
        {
            IsCancelled = true;
            // Publish the sale cancelled event
            PublishEvent(new SaleCancelledEvent(Id));
        }
    }

    public void UpdateTotalValue()
    {
        TotalValue = Items.Sum(item => item.TotalValue);
    }

    private void PublishEvent(object @event)
    {
        // Here, you can simulate publishing the event to a message broker
        Console.WriteLine($"Event published: {@event.GetType().Name}");
    }
}
