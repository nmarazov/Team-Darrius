namespace BudgetCalculator.Core.Expenses
{
    using System;
    using Enum;
    using BudgetCalculator.Core.Interface;

    public class Expenses : IExpenses
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
                return typeofExpense;
            }

            protected set
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

        ExpenseType IExpenses.TypeOfExpense
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
    }
}
