namespace BudgetCalculator.Core.Family
{
    using System.Collections.Generic;
    public class Family
    {
        public ICollection<FamilyMember> FamilyMembers { get; private set; }

        public string FamilyName { get; set; }

        public void AddMember(FamilyMember familyMember)
        {
            if (!this.FamilyMembers.Contains(familyMember))
            {
                this.FamilyMembers.Add(familyMember);
            }
        }
    }
}
