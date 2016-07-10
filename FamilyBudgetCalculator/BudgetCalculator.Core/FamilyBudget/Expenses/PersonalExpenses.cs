using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BudgetCalculator.Core.Enum;
using BudgetCalculator.Core.Interface;

namespace BudgetCalculator.Core.FamilyBudget.Expenses
{
    public class PersonalExpenses : Expenses, IPersonalExpenses
    {
        private PersonalExpensesType personalType;

        public PersonalExpenses(decimal amount, string comment, Interval period, PaymentType wayOfPayment, PersonalExpensesType personalType, DateTime date = default(DateTime))
            : base(amount, comment, period, wayOfPayment, date)
        {
            this.personalType = personalType;
        }

        public PersonalExpensesType PersonalType
        {
            get
            {
                return this.personalType;
            }
        }
    }

}
