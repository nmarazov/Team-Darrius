﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator.Core.Interface
{
    public interface IPersonalExpenses
    {
        IFamilyMember FamilyMember { get; set; }
    }
}
