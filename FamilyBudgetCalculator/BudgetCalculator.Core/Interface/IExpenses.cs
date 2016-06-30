namespace BudgetCalculator.Core.Interface
{
    using BudgetCalculator.Core.Enum;

    public interface IExpenses : IBudget
    {
        ExpenseType TypeOfExpense { get; set; }
    }
}
