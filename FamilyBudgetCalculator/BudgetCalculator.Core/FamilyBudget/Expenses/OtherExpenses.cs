using System;
using BudgetCalculator.Core.Enum;
using BudgetCalculator.Core.Interface;

namespace BudgetCalculator.Core.FamilyBudget.Expenses
{
    public class OtherExpenses : Expenses, INameable
    {
        public OtherExpenses(decimal amount, string comment, Interval period, PaymentType wayOfPayment, DateTime date = default(DateTime)) : base(amount, comment, period, wayOfPayment, date)
        {
            this.TypeOfExpense = ExpenseType.Other;
        }

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

        public override string ToString()
        {
            return base.ToString() + "#" + this.Name;
        }
    }
}
