namespace BudgetCalculator.Core.Interface
{
    using BudgetCalculator.Core.Enum;

    public interface IIncome
    {
        decimal Value { get; set; }

        Interval Period {get;set;}
    }
}
