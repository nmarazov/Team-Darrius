namespace BudgetCalculator.Core.FamilyBudget.Expenses
{
    using System;
    using BudgetCalculator.Core.Interface;
    using Enum;

    public abstract class Expenses : FundsOperation, IExpenses
    {
        private PaymentType wayOfPayment;

        public Expenses(decimal amount, string comment, Interval period, PaymentType wayOfPayment, DateTime date = default(DateTime))
            : base(amount, comment, period, date)
        {
            this.wayOfPayment = wayOfPayment;
        }

        public PaymentType WayOfPayment
        {
            get
            {
                return this.wayOfPayment;
            }
        }
    }
}
