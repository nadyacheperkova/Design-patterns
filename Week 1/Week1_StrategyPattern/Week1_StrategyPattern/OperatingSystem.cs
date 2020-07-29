using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_StrategyPattern
{
    class OperatingSystem
    {
        private ISchedule scheduling;
        private int next;
        private bool direction;

        public OperatingSystem()
        { 
            this.next = 0;
            this.direction = true;
        }

        public void ChangeAlgorithm(ISchedule algorithm)
        {
            this.scheduling = algorithm;
        }



        public int ReadNext(List<int> requests, int current)
        {
            this.next = this.scheduling.Schedule(requests, current, ref this.direction);
            return next;
        }
    }
}
