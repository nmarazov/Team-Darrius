using System;

public interface IBudget
{
    decimal Balance { get; set; }
    List<IExpense> Expenses { get; set; }
    List<IIncome> Incommings { get; set; }

}

public interface IFundOperation
{
    decimal Amount { get; set; }
    DateTime Date { get; set; }

    string Name { get; set; }
    string Comment { get; set; }
    Interval Period { get; set; }

}

public interface IExpenses : IFundOperation
{
    ExpenseType TypeOfExpense { get; set; }


}

public interface IIncome : IFundOperation
{
    //???
}

public interface IPersonalExpenses : IExpenses
{
    IFamilyMember FamilyMember { get; set; }
}

public interface IFamilyMember
{
    string Name { get; }

    sbyte Age { get; }

    FamilyMemberStatus Status { get; }
}
