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
            this.utilitiesType = utilitiesType;
        }

        public UtilitiesExpenseType UtilitiesType
        {
            get
            {
                return this.utilitiesType;
            }
        }
    }
}
