namespace BudgetCalculator.Core.FamilyBudget.Expenses.Accommodation
{
    using BudgetCalculator.Core.Enum;

    public class Accommodation : Expenses
    {
        private decimal value;

        public void Expenses(decimal value, Interval period)
        {
            this.Value = value;
            this.Period = period;
        }

        public decimal Value
        {
            get
            {
                return this.value;
            }

            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Expense cannot be negative");
                }

                this.value = value;
            }
        }

        public Interval Period { get; set; }
    }
}
