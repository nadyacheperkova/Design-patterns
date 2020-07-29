using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_StrategyPattern
{
    class FFCS : ISchedule
    {
        public int Schedule(List<int> toRead, int previous, ref bool direction)
        {
            return toRead.First();
        }

        public string GetName()
        {
            return "First Come First Serve";
        }
    }
}
