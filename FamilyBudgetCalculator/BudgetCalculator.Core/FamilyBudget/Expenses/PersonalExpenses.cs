using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BudgetCalculator.Core.Enum;
using BudgetCalculator.Core.Interface;

namespace BudgetCalculator.Core.FamilyBudget.Expenses
{
    public class PersonalExpenses : Expenses, IPersonalExpenses, INameable
    {
        public PersonalExpenses(decimal amount, string comment, Interval period, PaymentType wayOfPayment, DateTime date = default(DateTime)) : base(amount, comment, period, wayOfPayment, date)
        {
            this.TypeOfExpense = ExpenseType.Personal;
        }

        public IFamilyMember FamilyMember
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

        public string Name // e.g. cinema, girls, etc.
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
            return base.ToString() + "#" + this.FamilyMember.ToString() + "#" + this.Name;
        }
    }
}
