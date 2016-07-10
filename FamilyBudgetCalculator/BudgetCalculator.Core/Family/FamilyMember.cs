namespace BudgetCalculator.Core.Family
{
    using System;
    using Enum;
    using Interface;

    public class FamilyMember : IFamilyMember
    {
        private sbyte age;
        private string firstName;
        private string familyName;
        private FamilyMemberStatus familyMemeberStatus;

        public FamilyMember(string firstName, string familyName, sbyte age, FamilyMemberStatus status)
        {
            this.FirstName = firstName;
            this.FamilyName = familyName;
            this.age = age;
            this.Status = familyMemeberStatus;
        }

        [ValidateAge]
        public sbyte Age
        {
            set { this.age = value; }
            get { return this.age; }
        }

        [ValidateName]
        public string FirstName
        {
            set { this.firstName = value; }
            get { return this.firstName; }
        }

        [ValidateName]
        public string FamilyName
        {
            set { this.familyName = value; }
            get { return this.familyName; }
        }



        public FamilyMemberStatus Status
        {
            get { return this.familyMemeberStatus; }
            set { this.familyMemeberStatus = value; }
        }
    }
}
