namespace BudgetCalculator.Core.FamilyBudget.Expenses
{
    using System;
    using BudgetCalculator.Core.Interface;
    using Enum;

    public abstract class Expenses : Budget, IExpenses
    {
        private ExpenseType typeofExpense;

        public Interval Period
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public ExpenseType TypeOfExpense
        {
            get
            {
                return this.typeofExpense;
            }

            set
            {
                this.typeofExpense = value;
            }
        }

        public decimal Value
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public abstract decimal PayMoney();
    }
}
