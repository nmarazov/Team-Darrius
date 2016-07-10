namespace BudgetCalculator.Core.FamilyBudget.Income
{
    using System;
    using System.Collections.Generic;
    using Enum;
    using Interface;

    public abstract class Income : FundsOperation, IIncome
    {
        private IncomeType typeOfIncome;

        public Income(decimal amount, string comment, Interval period, IncomeType typeOfIncome, DateTime date = default(DateTime))
            : base(amount, comment, period, date)
        {
            this.typeOfIncome = typeOfIncome;
        }

        public IncomeType TypeOfIncome
        {
            get
            {
                return this.typeOfIncome;
            }
        }
    }
}
