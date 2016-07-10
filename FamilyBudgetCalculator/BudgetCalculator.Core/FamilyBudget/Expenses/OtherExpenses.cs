using System;
using BudgetCalculator.Core.Enum;
using BudgetCalculator.Core.Interface;

namespace BudgetCalculator.Core.FamilyBudget.Expenses
{
    public class OtherExpenses : Expenses, INameable
    {
        private string name;

        public OtherExpenses(decimal amount, string comment, Interval period, PaymentType wayOfPayment, DateTime date = default(DateTime)) : base(amount, comment, period, wayOfPayment, date)
        {
            this.TypeOfExpense = ExpenseType.Other;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "#" + this.Name;
        }

        public static OtherExpenses FromString(string input)
        {
            string[] split = input.Split('#');
            decimal value = decimal.Parse(split[1]);
            string comment = split[2];
            Interval interval = (Interval)System.Enum.Parse(typeof(Interval), split[3], true);
            PaymentType paymentType = (PaymentType)System.Enum.Parse(typeof(PaymentType), split[4], true);
            DateTime date = DateTime.Parse(split[5]);
            OtherExpenses expense = new OtherExpenses(value, comment, interval, paymentType, date);
            expense.Name = split[6];
            return expense;
        }
    }
}
