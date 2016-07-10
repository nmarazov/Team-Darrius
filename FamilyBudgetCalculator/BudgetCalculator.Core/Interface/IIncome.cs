namespace BudgetCalculator.Core.Interface
{
    using BudgetCalculator.Core.Enum;

    public interface IIncome 
    {
        IncomeType TypeOfIncome { get; set; }
    }
}
