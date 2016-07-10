namespace BudgetCalculator.Core.Interface
{
    using BudgetCalculator.Core.Enum;

    public interface IBudget
    {
        decimal Balance { get; set; }

        decimal Value { get; set; }

        Interval Period { get; set; }
    }
}