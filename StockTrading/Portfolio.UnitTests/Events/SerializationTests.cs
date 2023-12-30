using Portfolio.Domain.Events;
using System.Text.Json;

namespace Portfolio.UnitTests.Events
{
    public class SerializationTests
    {
        [Fact]
        public void SerializeAndDeserializePositionCreatedEvent()
        {
            var positionCreatedEvent = new PositionCreatedEvent(Guid.NewGuid());

            var json = JsonSerializer.Serialize(positionCreatedEvent);
            var deserializedEvent = JsonSerializer.Deserialize<PositionCreatedEvent>(json);

            Assert.True(deserializedEvent != null, "Could not deserialize PositionCreatedEvent");
            Assert.True(positionCreatedEvent.PositionId == deserializedEvent.PositionId, "Deserialized PositionCreatedEvent does not have correct PositionId");
        }

        [Fact]
        public void SerializeAndDeserializePositionDeletedEvent()
        {
            var positionDeletedEvent = new PositionDeletedEvent(Guid.NewGuid());

            var json = JsonSerializer.Serialize(positionDeletedEvent);
            var deserializedEvent = JsonSerializer.Deserialize<PositionDeletedEvent>(json);

            Assert.True(deserializedEvent != null, "Could not deserialize PositionDeletedEvent");
            Assert.True(positionDeletedEvent.PositionId == deserializedEvent.PositionId, "Deserialized PositionDeletedEvent does not have correct PositionId");
        }

        [Fact]
        public void SerializeAndDeserializeTradeAddedEvent()
        {
            var tradeAddedEvent = new TradeAddedEvent(Guid.NewGuid(), Guid.NewGuid(), "APPL", "XNAS", 42, 192.3, "USD", "Buy");

            var json = JsonSerializer.Serialize(tradeAddedEvent);
            var deserializedEvent = JsonSerializer.Deserialize<TradeAddedEvent>(json);

            Assert.True(deserializedEvent != null, "Could not deserialize TradeAddedEvent");
            Assert.True(tradeAddedEvent.PositionId == deserializedEvent.PositionId, "Deserialized TradeAddedEvent does not have correct PositionId");
            Assert.True(tradeAddedEvent.TradeId == deserializedEvent.TradeId, "Deserialized TradeAddedEvent does not have correct TradeId");
            Assert.True(tradeAddedEvent.Symbol == deserializedEvent.Symbol, "Deserialized TradeAddedEvent does not have correct Symbol");
            Assert.True(tradeAddedEvent.Exchange == deserializedEvent.Exchange, "Deserialized TradeAddedEvent does not have correct Exchange");
            Assert.True(tradeAddedEvent.Amount == deserializedEvent.Amount, "Deserialized TradeAddedEvent does not have correct Amount");
            Assert.True(tradeAddedEvent.Price == deserializedEvent.Price, "Deserialized TradeAddedEvent does not have correct Price");
            Assert.True(tradeAddedEvent.Currency == deserializedEvent.Currency, "Deserialized TradeAddedEvent does not have correct Currency");
            Assert.True(tradeAddedEvent.Way == deserializedEvent.Way, "Deserialized TradeAddedEvent does not have correct Way");
        }

        [Fact]
        public void SerializeAndDeserializeTradeDeletedEvent()
        {
            var tradeDeletedEvent = new TradeDeletedEvent(Guid.NewGuid(), Guid.NewGuid());

            var json = JsonSerializer.Serialize(tradeDeletedEvent);
            var deserializedEvent = JsonSerializer.Deserialize<TradeDeletedEvent>(json);

            Assert.True(deserializedEvent != null, "Could not deserialize TradeDeletedEvent");
            Assert.True(tradeDeletedEvent.PositionId == deserializedEvent.PositionId, "Deserialized TradeDeletedEvent does not have correct PositionId");
            Assert.True(tradeDeletedEvent.TradeId == deserializedEvent.TradeId, "Deserialized TradeDeletedEvent does not have correct TradeId");
        }
    }
}