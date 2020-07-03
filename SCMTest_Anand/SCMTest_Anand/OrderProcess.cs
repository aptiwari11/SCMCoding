using System;
using System.Collections.Generic;
using System.Text;
using SCMTest_Anand.Rules;

namespace SCMTest_Anand
{
    class OrderProcess : IOrderProcess
    {
        //IList<ProductOrderDeatils> prodRuleResults = new List<ProductOrderDeatils>();
        PaymnetTypeRule PaymentRule = new PaymnetTypeRule();

        //Populate this object for test purpose
        ProductOrderDeatils ProdOrder = new ProductOrderDeatils();

        void CreateProdOrderDeatils(ProductOrderDeatils productOrder)
        {
            ProdOrder.OrderNumber = 1;
            productOrder.PaymentDesc = "Paid";
            productOrder.PaymentType = PaymentDetail.PaymentTypes.PhysicalProduct.ToString();
            ProdOrder.TotalOrderCost = 100;
            ProdOrder.AgentComm = 0;
            ProdOrder.AgentCommPer = 5;
            ProdOrder.cutomerID = 101;

        }

        public List<string>  ValidateRules(List<string> PaymentType)
        {
            List<string> results = new List<string>();
            CreateProdOrderDeatils(ProdOrder);

            foreach (string p in PaymentType)
            {
                PaymentRule.RuleExcute(ProdOrder);
                results.Add("Rule Result for Payment Type:"+ p + 
                    "is" + ProdOrder.ValidationFlag.ToString()+
                    "/n Return Message from Rule:"+ 
                    ProdOrder.ValidationError.ToString());

            }
            // Return the result messages.
            return results;
        }
    }

    class IOrderProcess
    {
        IList<ProductOrderDeatils> PaymentDetail = new List<ProductOrderDeatils>();
    }
}

