
namespace Portfolio.Domain.Events
{
    internal class PositionDeletedEvent : PositionEvent
    {
        public PositionDeletedEvent(Guid positionId) : base(positionId)
        {
        }
    }
}
