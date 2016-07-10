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

    }
}
