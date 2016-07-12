namespace BudgetCalculator.Core.Family
{
    using System;
    using System.Text;
    using Enum;
    using Interface;

    public class FamilyMember : IFamilyMember, INameable
    {
        private sbyte age;
        private string name;
        
        private FamilyMemberStatus familyMemberStatus;

        public FamilyMember(string name, sbyte age, FamilyMemberStatus status)
        {
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
         
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }




        public FamilyMemberStatus Status
        {
            get { return this.familyMemberStatus; }
            set { this.familyMemberStatus = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendFormat("Name: {0}, age: {1}", this.Name, this.Age);
            return sb.ToString();
        }


    }
}
