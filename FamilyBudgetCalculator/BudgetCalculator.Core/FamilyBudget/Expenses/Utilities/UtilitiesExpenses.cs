using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetCalculator.Core.Enum;
using BudgetCalculator.Core.Interface;


namespace BudgetCalculator.Core.FamilyBudget.Expenses.Utilities
{
    public class UtilitiesExpenses : Expenses, IUtilitesExpenses
    {
        public UtilitiesExpenseType UtilitiesType
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
