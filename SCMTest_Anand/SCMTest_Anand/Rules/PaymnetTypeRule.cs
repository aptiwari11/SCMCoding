using System;
using System.Collections.Generic;
using System.Text;

namespace SCMTest_Anand.Rules
{
    class PaymnetTypeRule
    {
        ProductOrderDeatils ProdOrder = new ProductOrderDeatils();

        public bool ProductPaymentRule()
        {
            var PType = ProdOrder.PaymentType.ToString();
            if (PType == PaymentDetail.PaymentTypes.PhysicalProduct.ToString())
            {
                ProdOrder.ValidationFlag = true;
                ProdOrder.PackingSlip = true;
            }
            return true;

        }


        public bool BookPaymentRule()
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
                return true;
            }
            catch
            {
                ProdOrder.ValidationFlag = false;
                ProdOrder.ValidationError = ProdOrder.ValidationFlag + "Failed to validate Book Rule";
                return false;
            }
        }
    }
}
