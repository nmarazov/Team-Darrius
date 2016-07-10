namespace BudgetCalculator.Core.FamilyBudget.Expenses.Accommodation
{
    using System;
    using BudgetCalculator.Core.Enum;
    using Interface;

    public class AccommodationExpenses : Expenses, IAccomodationExpenses
    {
        private AccomodationExpenseType accommodationType;

        public AccommodationExpenses(decimal amount, string comment, Interval period, PaymentType wayOfPayment, AccomodationExpenseType accommodationType, DateTime date = default(DateTime))
            : base(amount, comment, period, wayOfPayment, date)
        {
            this.TypeOfExpense = ExpenseType.Accomodation;
            this.accommodationType = accommodationType;
        }

        public AccomodationExpenseType AccomodationType
        {
            get
            {
                return this.accommodationType;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.accommodationType.ToString();
        }

        public static AccommodationExpenses FromString(string input)
        {
            string[] split = input.Split(',');
            decimal value = decimal.Parse(split[1]);
            string comment = split[2];
            Interval interval = (Interval)System.Enum.Parse(typeof(Interval), split[3], true);
            PaymentType paymentType = (PaymentType)System.Enum.Parse(typeof(PaymentType), split[4], true);
            AccomodationExpenseType accExpenseType = (AccomodationExpenseType)System.Enum.Parse(typeof(AccomodationExpenseType), split[6], true);
            DateTime date = DateTime.Parse(split[5]);
            return new AccommodationExpenses(value,comment,interval,paymentType,accExpenseType,date);
        }
    }
}
