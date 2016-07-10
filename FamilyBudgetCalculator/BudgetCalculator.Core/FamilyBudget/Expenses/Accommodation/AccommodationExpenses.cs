namespace BudgetCalculator.Core.FamilyBudget.Expenses.Accommodation
{
    using System;
    using BudgetCalculator.Core.Enum;
    using Interface;

    public abstract class AccommodationExpenses : Expenses, IAccomodationExpenses
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
            return base.ToString() + "#" + this.accommodationType.ToString();
        }
    }
}
