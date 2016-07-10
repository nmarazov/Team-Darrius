using System.Collections.Generic;

namespace BudgetCalculator.Core.Interface
{
    public interface IBudget
    {
        decimal Balance { get; set; }
        List<IExpenses> Expenses { get; set; }
        List<IIncome> Incommings { get; set; }
    }
}