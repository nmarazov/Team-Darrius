namespace BudgetCalculator.Core.FamilyBudget
{
    using System;
    using BudgetCalculator.Core.Interface;

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
    }
}
