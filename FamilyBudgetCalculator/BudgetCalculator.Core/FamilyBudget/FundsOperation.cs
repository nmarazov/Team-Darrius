﻿using BudgetCalculator.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetCalculator.Core.Enum;

namespace BudgetCalculator.Core.FamilyBudget
{
    public abstract class FundsOperation : IFundsOperation // Common fields for both Income and Expense
    {
        private const int CommentMaxLength = 20;
        private const int CommentMinLength = 0;

        private decimal amount;
        private string comment;
        private DateTime date;
        private Interval period;

        public FundsOperation(decimal amount, string comment, Interval period, DateTime? date = null)
        {
            Validation.CheckIfPositive(amount, "Amount must be positive");
            this.amount = amount;
            
            Validation.CheckIfStringLengthIsValid(comment, CommentMaxLength,CommentMinLength,string.Format("Comment must be between {0} and {1} long",CommentMinLength, CommentMaxLength));
            this.comment = comment;

            this.period = period;
            
            if (date == null)
            {
                this.date = DateTime.Now.Date;
            }
            else
            {
                this.date = (DateTime)date;
            }
        }

        public decimal Amount
        {
            get
            {
                return this.amount;
            }
        }

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
