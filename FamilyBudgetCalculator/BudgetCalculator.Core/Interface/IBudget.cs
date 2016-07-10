using System.Collections.Generic;
using BudgetCalculator.Core.Interface;

namespace BudgetCalculator.Core.Interface
{
    public interface IBudget
    {
        decimal Balance { get; }
        ICollection<IExpenses> Expenses { get; }
        ICollection<IIncome> Incommings { get; }
    }
}