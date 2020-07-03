using System;
using System.Collections.Generic;
using System.Text;

namespace SCMTest_Anand.Rules
{
    public class EmailRules
    {

        public void EmailSendRule(ProductOrderDeatils ProdOrder)
        {
            var PType = ProdOrder.PaymentType.ToString();
            var pDesc = ProdOrder.PaymentDesc.ToString();
            if (PType == PaymentDetail.PaymentTypes.MemebershipActPayment.ToString() ||
                PType == PaymentDetail.PaymentTypes.MemebershipUpPayment.ToString())
            {
                ProdOrder.ValidationFlag = true;
                ProdOrder.Miscellaneous.Add("Email has been sent to customer:" +
                    ProdOrder.cutomerID);
            }

        }

    }
}
