namespace BudgetCalculator.Core.Interface
{
    using Enum;

    public interface IFamilyMember
    {
        string Name { get; }

        sbyte Age { get; }

        FamilyMemberStatus Status { get; }
    }
}
