using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class ApplyManager
    {

        private ILoggerService logger;

        public ApplyManager(ILoggerService logger)
        {
            this.logger = logger;
        }

        public void ApplyToCredit(ICreditManager creditManager)
        {
            //
            //
            //
            //checking business rules...

            creditManager.Calculate();

            logger.Log();
        }


    } 
}
