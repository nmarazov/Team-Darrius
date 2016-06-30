namespace BudgetCalculator.Core.Income
{
    using Enum;

    public class Salary : Income
    {
        public Salary(decimal value)
            :base(value, Interval.Monthly)
        {

        }
    }
}
