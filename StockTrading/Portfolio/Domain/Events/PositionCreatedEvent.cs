
namespace Portfolio.Domain.Events
{
    internal class PositionCreatedEvent : PositionEvent
    {
        public PositionCreatedEvent(Guid positionId) : base(positionId)
        {
        }
    }
}
