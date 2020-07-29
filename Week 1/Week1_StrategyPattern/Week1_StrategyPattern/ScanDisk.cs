using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_StrategyPattern
{
    class ScanDisk : ISchedule
    {
        public string GetName()
        {
            return "Scan Disk";
        }

        public int Schedule(List<int> toRead, int previous, ref bool direction)
        {
            bool tempDir = direction;
            int readValue = direction ? 100 : 0;
            List<int> sortedRequest = toRead.OrderBy(i => tempDir ? i : -i).ToList();

            foreach (int req in sortedRequest)
            {
                if (direction)
                {
                    if (req < previous)
                    {
                        continue;
                    }
                    readValue = req;
                    break;
                }
                if (req > previous)
                {
                    continue;
                }
                readValue = req;
                break;
            }
            if (readValue == 100 || readValue == 0)
            {
                direction = !direction;
            }

            return readValue;
        }
    }
}
