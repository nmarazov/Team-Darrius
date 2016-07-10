namespace BudgetCalculator.Core.FamilyBudget.Expenses
{
    using System;
    using BudgetCalculator.Core.Interface;
    using Enum;

    public abstract class Expenses : FundsOperation, IExpenses
    {
        public PaymentType WayOfPayment
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
