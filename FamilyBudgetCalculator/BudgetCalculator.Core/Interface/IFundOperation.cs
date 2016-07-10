using BudgetCalculator.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator.Core.Interface
{
    public interface IFundOperation
    {
        decimal Amount { get; set; }
        DateTime Date { get; set; }

        string Comment { get; set; }
        Interval Period { get; set; }

    }
}
