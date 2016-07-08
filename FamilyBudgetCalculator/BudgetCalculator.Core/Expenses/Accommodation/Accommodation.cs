using BudgetCalculator.Core.Enum;

namespace BudgetCalculator.Core.Expenses.Accommodation
{
    public class Accommodation : Expenses
    {
        decimal value;

        public void Expenses(decimal value, Interval period)
        {
            this.Value = value;
            this.Period = period;
        }

        public Interval Period { get; set; }

        public decimal Value
        {
            get { return this.value; }
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Expense cannot be negative");
                }

                this.value = value;
            }
        }
    }
}
