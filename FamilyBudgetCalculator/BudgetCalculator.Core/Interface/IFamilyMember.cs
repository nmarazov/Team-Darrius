namespace BudgetCalculator.Core.Interface
{
    using Enum;

    public interface IFamilyMember
    {
        string FirstName { get; set; }

        string FamilyName { get; set; }

        sbyte Age { get; }

        FamilyMemberStatus Status { get; }
    }
}
