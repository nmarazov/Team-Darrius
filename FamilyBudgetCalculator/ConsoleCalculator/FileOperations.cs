using BudgetCalculator.Core.Enum;
using BudgetCalculator.Core.Family;
using BudgetCalculator.Core.FamilyBudget.Expenses;
using BudgetCalculator.Core.FamilyBudget.Expenses.Accommodation;
using BudgetCalculator.Core.FamilyBudget.Expenses.LifeExpenses;
using BudgetCalculator.Core.FamilyBudget.Expenses.Utilities;
using BudgetCalculator.Core.FamilyBudget.Income;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleCalculator
{
    public static class FileOperations
    {
        public static void Save(string saveFileName,ICollection<FamilyMember> familyList, ICollection<Expenses> expenseList, ICollection<Income> incomeList)
        {
            string familyString = GetFamilyString(familyList);
            string expenseString = GetExpensesString(expenseList);
            string incomeString = GetIncomesString(incomeList);
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "FamilyBudgetCalculator",saveFileName);

            Directory.CreateDirectory(path);

            //Check if folder is created
            //if not create it 
            //Add folderpath

            System.IO.File.WriteAllText(Path.Combine(path,"family.txt"), familyString);
            System.IO.File.WriteAllText(Path.Combine(path,"expenses.txt"), expenseString);
            System.IO.File.WriteAllText(Path.Combine(path,"incomes.txt"), incomeString);
        }

        public static ICollection<FamilyMember> LoadFamily(string saveFileName)
        {
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "FamilyBudgetCalculator",saveFileName);
            ICollection<FamilyMember> family = new List<FamilyMember>();

            if (!Directory.Exists(path))
            {
                throw new Exception("NO SUCH SAVE FILE!");
            }
            else
            {
                string[] lines = File.ReadAllLines(Path.Combine(path, "family.txt"), Encoding.UTF8);
                foreach(var line in lines)
                {
                    family.Add(FamilyMember.FromString(line));
                }
            }

            return family;
        }

        public static ICollection<Income> LoadIncome(string saveFileName)
        {
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "FamilyBudgetCalculator", saveFileName);
            ICollection<Income> income = new List<Income>();

            if (!Directory.Exists(path))
            {
                throw new Exception("NO SUCH SAVE FILE!");
            }
            else
            {
                string[] lines = File.ReadAllLines(Path.Combine(path, "incomes.txt"), Encoding.UTF8);
                foreach (var line in lines)
                {
                    income.Add(Income.FromString(line));
                }
            }

            return income;
        }

        public static ICollection<Expenses> LoadExpenses(string saveFileName,List<FamilyMember> family)
        {
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "FamilyBudgetCalculator", saveFileName);
            ICollection<Expenses> expenses = new List<Expenses>();

            if (!Directory.Exists(path))
            {
                throw new Exception("NO SUCH SAVE FILE!");
            }
            else
            {
                string[] lines = File.ReadAllLines(Path.Combine(path, "expenses.txt"), Encoding.UTF8);
                foreach (var line in lines)
                {
                    string[] parts = line.Split('#');
                    ExpenseType type = (ExpenseType)System.Enum.Parse(typeof(ExpenseType), parts[0], true);

                    if(type == ExpenseType.Accomodation)
                    {
                        AccommodationExpenses expense = AccommodationExpenses.FromString(line);
                        expenses.Add(expense);
                    }
                    else if (type == ExpenseType.EveryDayLife)
                    {
                        EveryDayLifeExpenses expense = EveryDayLifeExpenses.FromString(line);
                        expenses.Add(expense);
                    }
                    else if (type == ExpenseType.Other)
                    {
                        OtherExpenses expense = OtherExpenses.FromString(line);
                        expenses.Add(expense);
                    }
                    else if (type == ExpenseType.Personal)
                    {
                        PersonalExpenses expense = PersonalExpenses.FromString(line,family);
                        expenses.Add(expense);
                    }
                    else if (type == ExpenseType.Utility)
                    {
                        UtilitiesExpenses expense = UtilitiesExpenses.FromString(line);
                        expenses.Add(expense);
                    }
                    else
                    {
                        throw new Exception("Unknown expense type!");
                    }
                }
            }

            return expenses;
        }

        private static string GetFamilyString(ICollection<FamilyMember> collection)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var member in collection)
            {
                sb.AppendLine(member.ToString());
            }

            return sb.ToString();
        }

        private static string GetExpensesString(ICollection<Expenses> collection)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var expense in collection)
            {
                if(expense.TypeOfExpense == ExpenseType.Accomodation)
                {
                    sb.AppendLine(((AccommodationExpenses)expense).ToString());
                }
                else if (expense.TypeOfExpense == ExpenseType.EveryDayLife)
                {
                    sb.AppendLine(((EveryDayLifeExpenses)expense).ToString());
                }
                else if (expense.TypeOfExpense == ExpenseType.Other)
                {
                    sb.AppendLine(((OtherExpenses)expense).ToString());
                }
                else if (expense.TypeOfExpense == ExpenseType.Personal)
                {
                    sb.AppendLine(((PersonalExpenses)expense).ToString());
                }
                else if(expense.TypeOfExpense == ExpenseType.Utility)
                {
                    sb.AppendLine(((UtilitiesExpenses)expense).ToString());
                }
                else
                {
                    throw new Exception("Unknown expense type");
                }
            }

            return sb.ToString();
        }

        private static string GetIncomesString(ICollection<Income> collection)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var income in collection)
            {
                sb.AppendLine(income.ToString());
            }

            return sb.ToString();
        }
    }
}
