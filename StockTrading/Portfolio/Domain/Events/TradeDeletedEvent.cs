
namespace Portfolio.Domain.Events
{
    internal class TradeDeletedEvent : PositionEvent
    {
        public Guid TradeId { get; set; }

        public TradeDeletedEvent(Guid positionId, Guid tradeId) : base(positionId)
        {
            TradeId = tradeId;
        }
    }
}
