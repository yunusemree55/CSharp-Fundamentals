using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class FarmCreditManager : ICreditManager
    {

        private ILoggerService logger;

        public FarmCreditManager(ILoggerService logger)
        {
            this.logger = logger;
        }

        public void Calculate()
        {
            Console.WriteLine("Farm Credit calculated");

            logger.Log();
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
