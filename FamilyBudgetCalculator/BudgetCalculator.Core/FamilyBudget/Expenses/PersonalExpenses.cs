using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BudgetCalculator.Core.Interface;

namespace BudgetCalculator.Core.FamilyBudget.Expenses
{
    public class PersonalExpenses : IPersonalExpenses, INameable
    {
        public IFamilyMember FamilyMember
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name // e.g. cinema, girls, etc.
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
