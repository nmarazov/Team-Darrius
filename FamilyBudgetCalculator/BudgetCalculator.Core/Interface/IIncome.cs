namespace BudgetCalculator.Core.Interface
{
    using BudgetCalculator.Core.Enum;

    public interface IIncome : IFundOperation
    {
        IncomeType TypeOfIncome;
    }
}
