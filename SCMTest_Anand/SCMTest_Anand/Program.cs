using System;
using System.Collections.Generic;

namespace SCMTest_Anand
{
    class Program
    {
        static void Main(string[] args)
        {
            // Excution of the program.
            //get the console rules names and order deatils.

            //call the validations rules

            //Print the rule result.

            OrderProcess OEP = new OrderProcess();
            List<string> RuleList = new List<string>();
            RuleList.Add(PaymentDetail.PaymentTypes.BookPayment.ToString());

            var results = OEP.ValidateRules(RuleList);
            Console.WriteLine("Deatils for rules result:{0}", results.ToString());

            //All of this can be done in Unite test class as well.
           
        }
    }
}
