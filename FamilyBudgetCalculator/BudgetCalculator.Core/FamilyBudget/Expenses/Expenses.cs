namespace BudgetCalculator.Core.FamilyBudget.Expenses
{
    using System;
    using BudgetCalculator.Core.Interface;
    using Enum;

    public abstract class Expenses : FundsOperation, IExpenses
    {
        private PaymentType wayOfPayment;
        private ExpenseType typeOfExpense;

        public Expenses(decimal amount, string comment, Interval period, PaymentType wayOfPayment, DateTime date = default(DateTime))
            : base(amount, comment, period, date)
        {
            this.wayOfPayment = wayOfPayment;
        }

        public ExpenseType TypeOfExpense
        {
            get
            {
                return typeOfExpense;
            }

            set
            {
                typeOfExpense = value;
            }
        }

        public PaymentType WayOfPayment
        {
            get
            {
                return this.wayOfPayment;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}#{1}#{2}#{3}#{4}", Amount.ToString(), Comment.ToString(), Period.ToString(), WayOfPayment.ToString(), Date.ToString());
        }
    }
}
