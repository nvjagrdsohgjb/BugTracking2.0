using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Classes
{
    public abstract class BaseTask
    {
        public abstract string name { get; set; }
        public abstract int prior { get; set; }
        public abstract int level { get; set; }
        public abstract int time { get; set; }
        public abstract int CalcPrior();
        public abstract int CalcTime();
    }
}
