﻿namespace BudgetCalculator.Core.Family
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

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", firstName, familyName, age.ToString(), familyMemeberStatus.ToString());
        }

        public static FamilyMember FromString(string input)
        {
            string[] split = input.Split(',');
            return new FamilyMember(split[0], split[1], sbyte.Parse(split[2]), (FamilyMemberStatus)System.Enum.Parse(typeof(FamilyMemberStatus), split[3], true));
        }
    }
}
