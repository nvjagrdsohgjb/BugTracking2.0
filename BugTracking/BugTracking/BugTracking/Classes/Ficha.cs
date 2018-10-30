using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Classes
{
    class Ficha : BaseTask
    {
        public override string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int prior { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int time { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int CalcPrior()
        {
            throw new NotImplementedException();
        }

        public override int CalcTime()
        {
            throw new NotImplementedException();
        }
    }
}
