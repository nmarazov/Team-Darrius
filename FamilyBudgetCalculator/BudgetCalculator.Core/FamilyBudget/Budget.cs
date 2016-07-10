namespace BudgetCalculator.Core.FamilyBudget
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BudgetCalculator.Core.Interface;
    using Enum;

    public class Budget : IBudget
    {
        private List<IExpenses> expenses;
        private List<IIncome> incomes;
        private decimal balance;

        public Budget()
        {
            this.Expenses = new List<IExpenses>();
            this.Incommings = new List<IIncome>();
        }

        public decimal Balance
        {
            get
            {
                return this.GetBalance();
            }
        }

        public ICollection<IExpenses> Expenses
        {
            get; protected set;
        }

        public ICollection<IIncome> Incommings
        {
            get; protected set;
        }

        private decimal GetBalance()
        {
            var incomeSum = this.Incommings.Sum(x => x.Amount);
            var expenseSum = this.Expenses.Sum(x => x.Amount);

            return incomeSum - expenseSum;
        }

        public void AddExpense(IExpenses expense)
        {
            this.Expenses.Add(expense);
        }

        public void AddIncome(IIncome income)
        {
            this.Incommings.Add(income);
        }

        public void RemoveExpense(IExpenses expense)
        {
            this.Expenses.Remove(expense);
        }

        public void RemoveIncome(IIncome income)
        {
            this.Incommings.Remove(income);
        }

        public ICollection<IIncome> GetIncomesByType(IncomeType type)
        {
            var incomesByType = this.Incommings.Where(x => x.TypeOfIncome == type).ToList();

            return incomesByType;
        }

        public ICollection<IIncome> GetIncomesByDate(DateTime startDate)
        {
            return this.GetIncomesByDate(startDate, DateTime.Now);
        }

        public ICollection<IIncome> GetIncomesByDate(DateTime startDate, DateTime endDate)
        {
            var incomesByDate = this.Incommings
                .Where(x => x.Date < endDate && x.Date > startDate)
                .ToList();

            return incomesByDate;
        }
    }
}
