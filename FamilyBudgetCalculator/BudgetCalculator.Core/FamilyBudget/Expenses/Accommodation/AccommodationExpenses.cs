namespace BudgetCalculator.Core.FamilyBudget.Expenses.Accommodation
{
    using System;
    using BudgetCalculator.Core.Enum;
    using Interface;
    public abstract class AccommodationExpenses : Expenses, IAccomodationExpenses
    {
        public AccomodationExpenseType AccomodationType
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
