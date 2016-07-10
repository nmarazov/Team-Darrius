using System.Collections.Generic;
using BudgetCalculator.Core.Interface;

namespace BudgetCalculator.Core.Interface
{
    public interface IBudget
    {
        decimal Balance { get; set; }
        ICollection<IExpenses> Expenses { get; set; }
        List<IIncome> Incommings { get; set; }
    }
}