using System;
using BudgetCalculator.Core.Enum;
using BudgetCalculator.Core.Interface;
using BudgetCalculator.Core.Family;
using System.Collections.Generic;

namespace BudgetCalculator.Core.FamilyBudget.Expenses
{
    public class PersonalExpenses : Expenses, IPersonalExpenses, INameable
    {
        private FamilyMember connectedFamilyMember;
        private string name;

        public PersonalExpenses(decimal amount, string comment, Interval period, PaymentType wayOfPayment, DateTime date = default(DateTime)) : base(amount, comment, period, wayOfPayment, date)
        {
            this.TypeOfExpense = ExpenseType.Personal;
        }

        public FamilyMember ConnectedFamilyMember
        {
            get
            {
                return connectedFamilyMember;
            }

            set
            {
                connectedFamilyMember = value;
            }
        }

        public string Name // e.g. cinema, girls, etc.
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "," +this.Name + "," +this.ConnectedFamilyMember.ToString();
        }

        public static PersonalExpenses FromString(string input,List<FamilyMember> familyMembers)
        {
            string[] split = input.Split(',');

            decimal value = decimal.Parse(split[1]);
            string comment = split[2];
            Interval interval = (Interval)System.Enum.Parse(typeof(Interval), split[3], true);
            PaymentType paymentType = (PaymentType)System.Enum.Parse(typeof(PaymentType), split[4], true);
            DateTime date = DateTime.Parse(split[5]);

            PersonalExpenses expense = new PersonalExpenses(value, comment, interval, paymentType, date);
            expense.Name = split[6];

            if(split.Length > 7)
            {
                //firstName, familyName, age.ToString(), familyMemeberStatus.ToString()
                string firstName = split[7];
                string lastName = split[8];
                string age = split[9];
                string status = split[10];

                string familyMemberString = string.Format("{0},{1},{2},{3}", firstName, lastName, age, status);

                FamilyMember comparer = FamilyMember.FromString(familyMemberString);
                FamilyMember trueMember = familyMembers.Find(x => x.ToString() == comparer.ToString());
                expense.ConnectedFamilyMember = trueMember;
            }
            else
            {
                throw new Exception("NO CONNECTED FAMILY MEMBER!");
            }

            return expense;
        }
    }
}
