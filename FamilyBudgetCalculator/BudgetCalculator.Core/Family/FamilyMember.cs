namespace BudgetCalculator.Core.Family
{
    using System;
    using Enum;
    using Interface;

    public class FamilyMember : IFamilyMember
    {
        [ValidateAge]
        public sbyte Age
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        [ValidateName]
        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public FamilyMemberStatus Status
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
