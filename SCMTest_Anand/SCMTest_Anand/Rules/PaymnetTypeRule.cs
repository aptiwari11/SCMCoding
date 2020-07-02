using System;
using System.Collections.Generic;
using System.Text;

namespace SCMTest_Anand.Rules
{
   public class PaymnetTypeRule
    {
        AgentPaymentRule AgentR = new AgentPaymentRule();
        ShippingRules ShipR = new ShippingRules();

        public void RuleExcute(ProductOrderDeatils ProdOrder)
        {
                 ProductPaymentRule(ProdOrder);
                 BookPaymentRule(ProdOrder);
                 VideoPaymentRule(ProdOrder);
        }

         public void ProductPaymentRule(ProductOrderDeatils ProdOrder)
        {
            var PType = ProdOrder.PaymentType.ToString();
            if (PType == PaymentDetail.PaymentTypes.PhysicalProduct.ToString())
            {
                ProdOrder.ValidationFlag = true;
                ProdOrder.PackingSlip = true;
                AgentR.AgentCommission(ProdOrder);
            }

        }


        public void BookPaymentRule(ProductOrderDeatils ProdOrder)
        {
            try
            {
                var PType = ProdOrder.PaymentType.ToString();
                if (PType == PaymentDetail.PaymentTypes.BookPayment.ToString())
                {
                    ProdOrder.PackingSlip = true;
                    ProdOrder.ValidationFlag = true;
                    ShipR.PackingSlipRule(ProdOrder);
                    AgentR.AgentCommission(ProdOrder);
                }
            }
            catch
            {
                ProdOrder.ValidationFlag = false;
                ProdOrder.ValidationError = 
                ProdOrder.ValidationFlag + "Failed to validate Book Rule";
            }
        }

        public void VideoPaymentRule(ProductOrderDeatils ProdOrder)
        {
            try
            {
                var PType = ProdOrder.PaymentType.ToString();
                if (PType == PaymentDetail.PaymentTypes.VideoPayment.ToString())
                {
                    ProdOrder.PackingSlip = true;
                    ProdOrder.ValidationFlag = true;
                    ShipR.PackingSlipRule(ProdOrder);
                }
            }
            catch
            {
                ProdOrder.ValidationFlag = false;
                ProdOrder.ValidationError =
                ProdOrder.ValidationFlag + "Failed to validate Video Payment Rule";
            }
        }
    }
}
