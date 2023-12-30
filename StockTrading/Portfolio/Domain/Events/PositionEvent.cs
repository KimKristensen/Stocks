namespace Portfolio.Domain.Events
{
    internal class PositionEvent
    {
        public Guid PositionId { get; set; }

        public PositionEvent(Guid positionId)
        {
            PositionId = positionId;
        }   
    }
}
