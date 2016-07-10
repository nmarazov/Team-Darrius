namespace BudgetCalculator.Core.FamilyBudget.Income
{
    using System;
    using Enum;

    public class OtherIncome : Income
    {
        public OtherIncome(decimal value, Interval period)
            : base(value, period)
        {
        }

        public override decimal GetMoney()
        {
            throw new NotImplementedException();
        }
    }
}
