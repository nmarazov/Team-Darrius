namespace BudgetCalculator.Core.FamilyBudget
{
    using BudgetCalculator.Core.Interface;
    using System;
    using BudgetCalculator.Core.Enum;
    using ValidationAttributes;
    public abstract class FundsOperation : IFundsOperation // Common fields for both Income and Expense
    {
        [ValidateAmount]
        public decimal Amount { get; set; }

        public string Comment
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

        public DateTime Date
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
    }
}
