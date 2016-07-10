namespace BudgetCalculator.Core.Interface
{
    using BudgetCalculator.Core.Enum;

    public interface IExpenses
    {
        ExpenseType TypeOfExpense { get; set; }
    }
}
