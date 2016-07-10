namespace BudgetCalculator.Core.FamilyBudget.Expenses.Utilities
{
    using System;
    using BudgetCalculator.Core.Enum;
    using BudgetCalculator.Core.Interface;

    public class UtilitiesExpenses : Expenses, IUtilitesExpenses
    {
        private UtilitiesExpenseType utilitiesType;

        public UtilitiesExpenses(decimal amount, string comment, Interval period, PaymentType wayOfPayment, UtilitiesExpenseType utilitiesType, DateTime date = default(DateTime))
            : base(amount, comment, period, wayOfPayment, date)
        {
            this.TypeOfExpense = ExpenseType.Utility;
            this.utilitiesType = utilitiesType;
        }

        public UtilitiesExpenseType UtilitiesType
        {
            get
            {
                return this.utilitiesType;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "#" + this.UtilitiesType.ToString();
        }

        public static UtilitiesExpenses FromString(string input)
        {
            string[] split = input.Split('#');
            decimal value = decimal.Parse(split[1]);
            string comment = split[2];
            Interval interval = (Interval)System.Enum.Parse(typeof(Interval), split[3], true);
            PaymentType paymentType = (PaymentType)System.Enum.Parse(typeof(PaymentType), split[4], true);
            UtilitiesExpenseType accExpenseType = (UtilitiesExpenseType)System.Enum.Parse(typeof(UtilitiesExpenseType), split[6], true);
            DateTime date = DateTime.Parse(split[5]);
            return new UtilitiesExpenses(value, comment, interval, paymentType, accExpenseType, date);
        }
    }
}
