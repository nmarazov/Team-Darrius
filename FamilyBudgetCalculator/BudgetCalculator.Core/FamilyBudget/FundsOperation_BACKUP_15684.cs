﻿namespace BudgetCalculator.Core.FamilyBudget
{
    using BudgetCalculator.Core.Interface;
    using System;
    using BudgetCalculator.Core.Enum;
    using ValidationAttributes;
    public abstract class FundsOperation : IFundsOperation // Common fields for both Income and Expense
    {
        private decimal amount;
        private string comment;
        private DateTime date;
        private Interval period;

        public FundsOperation(decimal amount, string comment, Interval period)
        {
            this.amount = amount;
            this.comment = comment;
            this.period = period;
            this.date = DateTime.Now.Date;
        }

        public FundsOperation(decimal amount, string comment, Interval period, DateTime date) 
            : this(amount, comment, period)
        {
            this.date = date;
        }

        public decimal Amount
        {
            get
            {
                return this.amount;
            }
        }

        [ValidateAmount]
        public decimal Amount { get; set; }

        public string Comment
        {
            get
            {
                return this.comment;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
        }

        public Interval Period
        {
            get
            {
                return this.period;
            }
        }
    }
}
