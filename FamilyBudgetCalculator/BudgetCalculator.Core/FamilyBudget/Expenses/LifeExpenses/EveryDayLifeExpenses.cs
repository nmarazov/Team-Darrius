namespace BudgetCalculator.Core.FamilyBudget.Expenses.LifeExpenses
{
    using System;
    using BudgetCalculator.Core.Enum;
    using BudgetCalculator.Core.Interface;
    
    public class EveryDayLifeExpenses : Expenses, IEveryDayLifeExpenses
    {
        private EveryDayLifeExpenseType everyDayLife;

        public EveryDayLifeExpenses(decimal amount, string comment, Interval period, PaymentType wayOfPayment, EveryDayLifeExpenseType everyDayLife, DateTime date = default(DateTime))
            : base(amount, comment, period, wayOfPayment, date)
        {
            this.TypeOfExpense = ExpenseType.EveryDayLife;
            this.everyDayLife = everyDayLife;
        }

        public EveryDayLifeExpenseType EveryDayLife
        {
            get
            {
                return this.everyDayLife;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.EveryDayLife.ToString();
        }

        public static EveryDayLifeExpenses FromString(string input)
        {
            string[] split = input.Split(',');
            decimal value = decimal.Parse(split[1]);
            string comment = split[2];
            Interval interval = (Interval)System.Enum.Parse(typeof(Interval), split[3], true);
            PaymentType paymentType = (PaymentType)System.Enum.Parse(typeof(PaymentType), split[4], true);
            EveryDayLifeExpenseType accExpenseType = (EveryDayLifeExpenseType)System.Enum.Parse(typeof(EveryDayLifeExpenseType), split[6], true);
            DateTime date = DateTime.Parse(split[5]);
            return new EveryDayLifeExpenses(value, comment, interval, paymentType, accExpenseType, date);
        }
    }
}
