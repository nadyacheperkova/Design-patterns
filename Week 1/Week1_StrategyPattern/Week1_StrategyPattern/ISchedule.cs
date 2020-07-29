using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_StrategyPattern
{
    interface ISchedule
    {
        string GetName();
        int Schedule(List<int> toRead, int previous, ref bool direction);
    }
}
