using BudgetCalculator.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator.Core.Interface
{
    public interface IUtilitesExpenses : IExpenses
    {
        UtilitiesExpenseType UtilitiesType { get; set; }
    }
}
