namespace Portfolio.Domain.Model;

internal class Position
{
    private readonly List<Trade> _trades;

    public Position()
    {
        _trades = new List<Trade>();
    }
}
