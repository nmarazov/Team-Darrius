namespace BudgetCalculator.Core.FamilyBudget.Income
{
    using Enum;

    public class Salary : Income
    {
        public Salary(decimal value)
            : base(value, Interval.Monthly)
        {
        }
    }
}
