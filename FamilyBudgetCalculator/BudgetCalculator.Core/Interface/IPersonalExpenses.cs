using BudgetCalculator.Core.Family;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator.Core.Interface
{
    public interface IPersonalExpenses
    {
        FamilyMember ConnectedFamilyMember { get; set; }
    }
}
