namespace Domain.Events
{
    public class ItemCancelledEvent
    {
        public Guid ItemId { get; }

        public ItemCancelledEvent(Guid itemId)
        {
            ItemId = itemId;
        }
    }

}
