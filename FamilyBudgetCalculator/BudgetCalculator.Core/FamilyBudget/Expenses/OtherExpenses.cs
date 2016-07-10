using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetCalculator.Core.Interface;
using BudgetCalculator.Core.Enum;

namespace BudgetCalculator.Core.FamilyBudget.Expenses
{
    public class OtherExpenses : Expenses, IOtherExpenses
    {
        private OtherExpensesType otherType;

        public OtherExpenses(decimal amount, string comment, Interval period, PaymentType wayOfPayment, OtherExpensesType otherType, DateTime date = default(DateTime))
            : base(amount, comment, period, wayOfPayment, date)
        {
            this.otherType = otherType;
        }

        public OtherExpensesType OthersType
        {
            get
            {
                return this.otherType;
            }
        }
    }

}


