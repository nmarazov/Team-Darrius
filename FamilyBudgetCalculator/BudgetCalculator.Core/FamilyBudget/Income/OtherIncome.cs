namespace BudgetCalculator.Core.FamilyBudget.Income
{
    using Enum;

    public class OtherIncome : Income
    {
        public OtherIncome(decimal value, Interval period)
            : base(value, period)
        {
        }
    }
}
