using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Business.Import
{
    public class StrategyContext
    {
        private CreateStrategy strategy;

        public StrategyContext(CreateStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void executeStrategy(int num1, int num2)
        {
            strategy.CreateMember();
        }
    }
}
