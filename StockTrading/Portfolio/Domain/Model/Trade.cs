namespace Portfolio.Domain.Model;

internal class Trade
{
    private readonly Guid _id;
    private readonly FinancialInstrument _financialInstrument;

    public Trade(Guid id, FinancialInstrument financialInstrument)
    {
        _id = id;
        _financialInstrument = financialInstrument;
    }
}
