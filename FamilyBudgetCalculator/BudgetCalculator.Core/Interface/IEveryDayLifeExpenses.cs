using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator.Core.Interface
{
    public interface IEveryDayLifeExpenses : IExpenses
    {
        EveryDayLifeExpenceType EveryDayLife { get; set; }
    }
}
