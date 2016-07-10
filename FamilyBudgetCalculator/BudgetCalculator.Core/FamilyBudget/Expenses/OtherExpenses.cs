using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetCalculator.Core.Interface;

namespace BudgetCalculator.Core.FamilyBudget.Expenses
{
    public class OtherExpenses : Expenses, INameable
    {
        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
