namespace BudgetCalculator.Core.Family
{
    using System;
    using Enum;
    using Interface;

    public class FamilyMember : IFamilyMember, INameable
    {
        private sbyte age;
        // private string firstName;
        // private string familyName;
        private string name;
        
        private FamilyMemberStatus familyMemberStatus;

        //public FamilyMember(string firstName, string familyName, sbyte age, FamilyMemberStatus status)
        public FamilyMember(string name, sbyte age, FamilyMemberStatus status)
        {
            //this.FirstName = firstName;
            //this.FamilyName = familyName;
            this.Name = name;
            this.Age = age;
            this.Status = familyMemberStatus;
        }

        [ValidateAge]
        public sbyte Age
        {
            set { this.age = value; }
            get { return this.age; }
        }

        [ValidateName]
        //public string FirstName { get; set; }
        public string Name
        {
            set { this.Name = value; }
            get { return this.Name; }
        }

         //   [ValidateName]

        //public string FamilyName
        //{
        //    set { this.familyName = value; }
        //    get { return this.familyName; }
        //}



        public FamilyMemberStatus Status
        {
            get { return this.familyMemberStatus; }
            set { this.familyMemberStatus = value; }
        }

    }
}
