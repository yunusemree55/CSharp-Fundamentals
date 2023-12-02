using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class HousingCreditManager : ICreditManager
    {
        private ILoggerService logger;

        public HousingCreditManager(ILoggerService logger)
        {
            this.logger = logger;
        }

        public void Calculate()
        {
            Console.WriteLine("Housing Credit calculated");

            logger.Log();
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
