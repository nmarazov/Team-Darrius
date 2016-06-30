namespace BudgetCalculator.Core.Income
{

    using System;
    using System.Collections.Generic;
    using Enum;
    using Interface;

    public class Income : IIncome
    {
        decimal value;

        public Income(decimal value, Interval period)
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
                    throw new ArgumentOutOfRangeException("Income cannot be negative");
                }

                this.value = value;
            }
        }
    }
}
