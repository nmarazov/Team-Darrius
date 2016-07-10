namespace BudgetCalculator.Core.FamilyBudget.Income
{
    using System;
    using Enum;

    public class Salary : Income
    {
        public Salary(decimal value)
            : base(value, Interval.Monthly)
        {
        }

        public override decimal GetMoney()
        {
            throw new NotImplementedException();
        }
    }
}
