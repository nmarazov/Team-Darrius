namespace BudgetCalculator.Core.Interface
{
    using Enum;

    public interface IFamilyMember: INameable
    {
        //string FirstName { get; set; }

        //string FamilyName { get; set; }

        //string Name { get; set; }

        sbyte Age { get; }

        FamilyMemberStatus Status { get; }
    }
}
