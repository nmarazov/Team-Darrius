namespace BudgetCalculator.Core.FamilyBudget.Expenses.Utilities
{
    using System;
    using BudgetCalculator.Core.Enum;
    using BudgetCalculator.Core.Interface;

    public class UtilitiesExpenses : Expenses, IUtilitesExpenses
    {
        private UtilitiesExpensesType utilitiesType;

        public UtilitiesExpenses(decimal amount, string comment, Interval period, PaymentType wayOfPayment, UtilitiesExpensesType utilitiesType, DateTime date = default(DateTime))
            : base(amount, comment, period, wayOfPayment, date)
        {
            this.utilitiesType = utilitiesType;
        }

        public UtilitiesExpensesType UtilitiesType
        {
            get
            {
                return this.utilitiesType;
            }
        }
    }
}
