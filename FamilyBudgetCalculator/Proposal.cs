using System;

// ENUMERATIONS
public enum Interval
{
    Dayly,
    Weekly,
    Monthly,
    Yearly,
    OneTime
}

public enum PaymentType
{
    Cash,
    CreditCard,
    DebitCard,
    BankTransfer
}

public enum AccomodationExpenceType
{
    Rent,
    Mortgage,
    Insurance,
    Taxes,
    Maintanence
}

public enum UtilitiesExpenceType
{
    Electricity,
    Water,
    Heating,
    Phones,
    Internet,
    TV
}

public enum EveryDayLifeExpenceType
{
    Food,
    Car,
    Transportation,
    Health
}

public enum IncomeType
{
    Salary,
    Rent,
    Business,
    Other
}

//CLASS MODELS

public interface IBudget
{
    decimal Balance { get; set; }
    List<IExpenses> Expenses { get; set; }
    List<IIncome> Incommings { get; set; }

}

public interface IFundOperation
{
    decimal Amount { get; set; }
    DateTime Date { get; set; }

    string Comment { get; set; }
    Interval Period { get; set; }

}

public interface IExpenses : IFundOperation
{
    PaymentType WayOfPayment { get; set; }

}


public interface IAccomodationExpenses : IExpenses
{
    AccomodationExpenceType AccomodationType { get; set; }
}

public interface IUtilitesExpenses : IExpenses
{
    UtilitiesExpenceType UtilitiesType { get; set; }
}

public interface EveryDayLifeExpenses : IExpenses
{
    EveryDayLifeExpenceType EveryDayLife { get; set; }
}


public interface IPersonalExpenses : IExpenses
{
    IFamilyMember FamilyMember { get; set; }
}

public interface IOtherExpenses : INameable
{

}

public interface IIncome : IFundOperation
{
    IncomeType TypeOfIncome;
}


public interface IFamilyMember
{
    string Name { get; }

    sbyte Age { get; }

    FamilyMemberStatus Status { get; }
}

public interface INameable
{
    string Name { get; set; }

}
