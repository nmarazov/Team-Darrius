namespace BudgetCalculator.Core.FamilyBudget
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BudgetCalculator.Core.Interface;
    using Enum;

    public static class Budget 
    {
        public static List<IExpenses> expenses = new List<IExpenses>();
        public static List<IIncome> incomes = new List<IIncome>();
        public static decimal balance;

       

        public static decimal Balance
        {
            get
            {
                return GetBalance();
            }
        }

        

        private static decimal GetBalance()
        {
            var incomeSum = Budget.incomes.Sum(x => x.Amount);
            var expenseSum = Budget.expenses.Sum(x => x.Amount);

            return incomeSum - expenseSum;
        }

        public static void AddExpense(IExpenses expense)
        {
            Budget.expenses.Add(expense);
        }

        public static void AddIncome(IIncome income)
        {
            Budget.incomes.Add(income);
        }

        public static void RemoveExpense(IExpenses expense)
        {
            Budget.expenses.Remove(expense);
        }

        public static void RemoveIncome(IIncome income)
        {
            Budget.incomes.Remove(income);
        }

        public static ICollection<IIncome> GetIncomesByType(IncomeType type)
        {
            var incomesByType = Budget.incomes.Where(x => x.TypeOfIncome == type).ToList();

            return incomesByType;
        }

        public static ICollection<IIncome> GetIncomesByDate(DateTime startDate)
        {
            return Budget.GetIncomesByDate(startDate, DateTime.Now);
        }

        public static ICollection<IIncome> GetIncomesByDate(DateTime startDate, DateTime endDate)
        {
            var incomesByDate = Budget.incomes
                .Where(x => x.Date < endDate && x.Date > startDate)
                .ToList();

            return incomesByDate;
        }
    }
}
