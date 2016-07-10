namespace BudgetCalculator.Core.FamilyBudget.Income
{
    using System;
    using Enum;
    using Interface;

    public class Income : FundsOperation, IIncome
    {
        private IncomeType typeOfIncome;

        public Income(decimal amount, string comment, Interval period, IncomeType typeOfIncome, DateTime date = default(DateTime))
            : base(amount, comment, period, date)
        {
            this.typeOfIncome = typeOfIncome;
        }

        public IncomeType TypeOfIncome
        {
            get
            {
                return this.typeOfIncome;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}#{1}#{2}#{3}#{4}", Amount.ToString(), Comment, Period.ToString(), TypeOfIncome.ToString(), Date.ToString());
        }

        public static Income FromString(string input)
        {
            string[] split = input.Split('#');
            return new Income(
                decimal.Parse(split[0]),
                split[1],
                (Interval)System.Enum.Parse(typeof(Interval), split[2], true),
                (IncomeType)System.Enum.Parse(typeof(IncomeType), split[3], true),
                DateTime.Parse(split[4])
                );
        }
    }
}
