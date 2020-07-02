using System;
using System.Collections.Generic;
using System.Text;

namespace SCMTest_Anand.Rules
{
    class AgentPaymentRule
    {
        ProductOrderDeatils ProdOrder = new ProductOrderDeatils();

        public bool AgentCommission()
        {
            try
            {
                var PType = ProdOrder.PaymentType.ToString();
                if (PType == PaymentDetail.PaymentTypes.BookPayment.ToString())
                {
                    ProdOrder.ValidationFlag = true;
                    ProdOrder.AgentComm = ProdOrder.AgentCommPer * ProdOrder.TotalOrderCost / 100;
                }
                return true;
            }

            catch
            {
                ProdOrder.ValidationFlag = false;
                ProdOrder.ValidationError = ProdOrder.OrderNumber +
                    "Validation failed for Agent Commision";
                return false;
            }


        }
    }
}
