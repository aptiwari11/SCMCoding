using System;
using System.Collections.Generic;
using System.Text;

namespace SCMTest_Anand.Rules
{
   public class ShippingRules
    {

         public void PackingSlipRule(ProductOrderDeatils ProdOrder)
        {
                var PType = ProdOrder.PaymentType.ToString();
                var pDesc = ProdOrder.PaymentDesc.ToString();
                if (PType == PaymentDetail.PaymentTypes.BookPayment.ToString())
                {   
                    ProdOrder.PackingSlip = true;
                    ProdOrder.ValidationFlag = true;
                    ProdOrder.Miscellaneous = ProdOrder.Miscellaneous+
                    "Duplicate Packing Slip for Royalty Department";
                }


                if (PType == PaymentDetail.PaymentTypes.VideoPayment.ToString() && 
                pDesc == "Learning To Ski")
                {
                    ProdOrder.PackingSlip = true;
                    ProdOrder.ValidationFlag = true;
                    ProdOrder.Miscellaneous= ProdOrder.Miscellaneous+
                    "Adding first add video to packinglist for OrderID:"
                        + ProdOrder.OrderNumber;
                }

        }

    }
}
