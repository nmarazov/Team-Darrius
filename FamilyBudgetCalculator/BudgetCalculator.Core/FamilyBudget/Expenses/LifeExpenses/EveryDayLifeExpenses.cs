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
            return base.ToString() + "#" + this.EveryDayLife.ToString();
        }
    }
}
