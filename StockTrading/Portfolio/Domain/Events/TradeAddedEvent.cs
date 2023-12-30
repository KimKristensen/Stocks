
namespace Portfolio.Domain.Events
{
    internal class TradeAddedEvent : PositionEvent
    {
        public Guid TradeId { get; set; }
        public string Symbol { get; set; }
        public string Exchange { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }
        public string Way {  get; set; }

        public TradeAddedEvent(
            Guid positionId,
            Guid tradeId,
            string symbol,
            string exchange,
            double amount,
            double price,
            string currency,
            string way) : base(positionId)
        {
            TradeId = tradeId;
            Symbol = symbol;
            Exchange = exchange;
            Amount = amount;
            Price = price;
            Currency = currency;
            Way = way;
        }
    }
}
