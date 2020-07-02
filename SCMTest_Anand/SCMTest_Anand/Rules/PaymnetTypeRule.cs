using System;
using System.Collections.Generic;
using System.Text;

namespace SCMTest_Anand.Rules
{
    class PaymnetTypeRule
    {

        public void RuleExcute(ProductOrderDeatils ProdOrder)
        {
                 ProductPaymentRule(ProdOrder);
                 BookPaymentRule(ProdOrder);
        }

        public void ProductPaymentRule(ProductOrderDeatils ProdOrder)
        {
            var PType = ProdOrder.PaymentType.ToString();
            if (PType == PaymentDetail.PaymentTypes.PhysicalProduct.ToString())
            {
                ProdOrder.ValidationFlag = true;
                ProdOrder.PackingSlip = true;
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
                    ProdOrder.Miscellaneous = "Duplicate Packing Slip for Royalty Department";
                }
            }
            catch
            {
                ProdOrder.ValidationFlag = false;
                ProdOrder.ValidationError = 
                    ProdOrder.ValidationFlag + "Failed to validate Book Rule";
            }
        }
    }
}
