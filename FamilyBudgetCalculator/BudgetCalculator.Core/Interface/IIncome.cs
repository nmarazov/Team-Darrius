namespace BudgetCalculator.Core.Interface
{
    using BudgetCalculator.Core.Enum;

    public interface IIncome : IFundsOperation
    {
        IncomeType TypeOfIncome { get; }
    }
}
