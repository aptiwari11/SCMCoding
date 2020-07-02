using System;
using System.Collections.Generic;
using System.Text;

namespace SCMTest_Anand.Rules
{
    class AgentPaymentRule
    {

        public void AgentCommission(ProductOrderDeatils ProdOrder)
        {
            try
            {
                    ProdOrder.ValidationFlag = true;
                    ProdOrder.AgentComm = ProdOrder.AgentCommPer * ProdOrder.TotalOrderCost / 100;
            }

            catch
            {
                ProdOrder.ValidationFlag = false;
                ProdOrder.ValidationError = ProdOrder.OrderNumber +
                    "Validation failed for Agent Commision";
            }


        }
    }
}
