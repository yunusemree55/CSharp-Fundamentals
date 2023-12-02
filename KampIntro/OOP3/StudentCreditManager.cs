using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class StudentCreditManager : ICreditManager
    {

        private ILoggerService logger;

        public StudentCreditManager(ILoggerService logger)
        {
            this.logger = logger;
        }

        public void Calculate()
        {
            Console.WriteLine("Student Credit calculated");

            logger.Log();
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
