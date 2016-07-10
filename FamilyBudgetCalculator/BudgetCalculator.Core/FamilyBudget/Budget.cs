namespace BudgetCalculator.Core.FamilyBudget
{
    using System;
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
    }
}
