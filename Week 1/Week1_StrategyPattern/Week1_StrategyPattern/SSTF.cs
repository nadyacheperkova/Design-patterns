using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_StrategyPattern
{
    class SSTF : ISchedule
    {
        public string GetName()
        {
            return "Shortest Seek Time First";
        }

        public int Schedule(List<int> toRead, int previous, ref bool direction)
        {
            int closestToPrevious = 5000000;
            int closestPos = -1;

            foreach (int req in toRead)
            {
                int distance = Math.Abs(previous - req);
                if (distance >= closestToPrevious)
                {
                    continue;
                }
                closestToPrevious = distance;
                closestPos = req;
            }

            return closestPos;
        }
    }
}
