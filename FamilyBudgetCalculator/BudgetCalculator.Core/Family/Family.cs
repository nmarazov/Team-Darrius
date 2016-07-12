namespace BudgetCalculator.Core.Family
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Family
    {
        public static ICollection<FamilyMember> FamilyMembers = new List<FamilyMember>();

        public static string FamilyName { get; set; }

        public static void AddMember(FamilyMember familyMember)
        {
            //if (!Family.FamilyMembers.Contains(familyMember))
            //{
            //if (Family.FamilyMembers == null)
                //FamilyMembers = ;
                Family.FamilyMembers.Add(familyMember);
            //}
        }

        public static void Print()
        {
            
            foreach (var member in Family.FamilyMembers)
            {
                Console.WriteLine(member.ToString());
            }
            
        }
    }
}
