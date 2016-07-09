namespace BudgetCalculator.Core.Interface
{
    using BudgetCalculator.Core.Enum;

    public interface IExpenses
    {
        ExpenseType TypeOfExpense { get; set; }

        decimal Value { get; set; }

        Interval Period { get; set; }
    }
}
