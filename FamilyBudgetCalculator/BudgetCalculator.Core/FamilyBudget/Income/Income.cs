namespace BudgetCalculator.Core.FamilyBudget.Income
{
    using System;
    using System.Collections.Generic;
    using Enum;
    using Interface;

    public abstract class Income : FundsOperation, IIncome
    {
        

        public IncomeType TypeOfIncome
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
