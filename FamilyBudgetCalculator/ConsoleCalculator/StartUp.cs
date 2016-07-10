namespace ConsoleCalculator
{
    using global::BudgetCalculator.Core.Enum;
    using global::BudgetCalculator.Core.Family;
    using global::BudgetCalculator.Core.FamilyBudget.Expenses;
    using global::BudgetCalculator.Core.FamilyBudget.Expenses.Accommodation;
    using global::BudgetCalculator.Core.FamilyBudget.Expenses.LifeExpenses;
    using global::BudgetCalculator.Core.FamilyBudget.Expenses.Utilities;
    using global::BudgetCalculator.Core.FamilyBudget.Income;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            TestSave("TestSave");
        }

        static void TestSave(string saveFileName)
        {
            #region DummyVariables
            FamilyMember newMember1 = new FamilyMember("Petar", "Petrov", 15, FamilyMemberStatus.Child);
            FamilyMember newMember2 = new FamilyMember("Gosho", "Toshev", 25, FamilyMemberStatus.Working);

            List<FamilyMember> familyList = new List<FamilyMember>() { newMember1, newMember2 };

            Income income1 = new Income(12.5m, "Ot narkotici", Interval.Dayly, IncomeType.Business);
            Income income2 = new Income(125000m, "Montor na mivki", Interval.Yearly, IncomeType.Salary);

            List<Income> incomeList = new List<Income>() { income1, income2 };

            AccommodationExpenses livingExpense = new AccommodationExpenses(12.5m, "Mansarda", Interval.Monthly, PaymentType.BankTransfer, AccomodationExpenseType.Rent);
            EveryDayLifeExpenses dailyExpense = new EveryDayLifeExpenses(20m, "Junk food", Interval.Monthly, PaymentType.Cash, EveryDayLifeExpenseType.Food);
            UtilitiesExpenses waterBill = new UtilitiesExpenses(20m, "Rujdiva voda", Interval.Monthly, PaymentType.BankTransfer, UtilitiesExpenseType.Water, new DateTime(1992, 2, 3));
            OtherExpenses otherExpense = new OtherExpenses(300m, "Reket", Interval.Dayly, PaymentType.Cash);
            PersonalExpenses personalExpense = new PersonalExpenses(140m, "Var", Interval.OneTime, PaymentType.Cash, DateTime.Now.AddDays(2));
            personalExpense.ConnectedFamilyMember = newMember1;

            List<Expenses> expenseList = new List<Expenses>()
            {
                livingExpense,
                dailyExpense,
                waterBill,
                otherExpense,
                personalExpense
            };
            #endregion

            FileOperations.Save(saveFileName, familyList, expenseList, incomeList);


            //-------------------LOAD----------------
            var family = FileOperations.LoadFamily(saveFileName);
            var income = FileOperations.LoadIncome(saveFileName);
            var expenses = FileOperations.LoadExpenses(saveFileName, family.ToList());


            Console.WriteLine("----------------------------FAMILY MEMBERS---------------------------");
            foreach(var member in family)
            {
                Console.WriteLine(member.ToString());
            }

            Console.WriteLine("----------------------------INCOMES---------------------------");

            foreach (var inc in income)
            {
                Console.WriteLine(inc.ToString());
            }

            Console.WriteLine("----------------------------EXPENSES---------------------------");

            foreach (var expense in expenses)
            {
                Console.WriteLine(expense.ToString());
            }

        }
    }
}
