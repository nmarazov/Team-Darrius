namespace BudgetCalculator.Core.Interface
{
    using BudgetCalculator.Core.Enum;

    public interface IExpenses 
    {
        PaymentType WayOfPayment { get; set; }

    }
}
