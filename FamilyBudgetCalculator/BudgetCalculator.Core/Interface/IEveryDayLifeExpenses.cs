using BudgetCalculator.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator.Core.Interface
{
    public interface IEveryDayLifeExpenses : IExpenses
    {
        EveryDayLifeExpenseType EveryDayLife { get; set; }
    }
}
