namespace BudgetCalculator.Core.FamilyBudget
{
    using System;
    using System.Collections.Generic;
    using BudgetCalculator.Core.Interface;
    using Enum;

    public abstract class Budget : IBudget
    {
        public decimal Balance
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

        public List<IExpenses> Expenses
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

        public List<IIncome> Incommings
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
