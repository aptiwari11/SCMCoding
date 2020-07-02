using System;
using System.Collections.Generic;
using System.Text;
using SCMTest_Anand.Rules;

namespace SCMTest_Anand
{
    class OrderProcess : IOrderProcess
    {
        public List<ProductOrderDeatils>  ValidateRules(List<string> PaymentType)
        {
            IList<ProductOrderDeatils> prodRuleResults = new List<ProductOrderDeatils>();
            foreach (string p in PaymentType)
            {
                // how to run all the rules in one loop.

            }
            // Return the result object with deatils.
            return new List<ProductOrderDeatils>();
        }
    }

    class IOrderProcess
    {
        IList<ProductOrderDeatils> PaymentDetail = new List<ProductOrderDeatils>();
    }
}

