namespace BudgetCalculator.Core.Interface
{
    using BudgetCalculator.Core.Enum;

    public interface IExpenses : IFundsOperation
    {
        PaymentType WayOfPayment { get; set; }

    }
}
