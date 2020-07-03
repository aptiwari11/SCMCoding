using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCMTest_Anand;
using SCMTest_Anand.Rules;

namespace RulesUnitTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void ExcuteAllRules()
        {
            ProductOrderDeatils ProdOrder = new ProductOrderDeatils();
            ProdOrder.OrderNumber = 1;
            ProdOrder.PaymentDesc = "Learning To Ski";
            ProdOrder.PaymentType = PaymentDetail.PaymentTypes.VideoPayment.ToString();
            ProdOrder.TotalOrderCost = 100;
            ProdOrder.AgentComm = 0;
            ProdOrder.AgentCommPer = 5;

            PaymnetTypeRule PaymentRule = new PaymnetTypeRule();
            PaymentRule.RuleExcute(ProdOrder);
            Assert.AreEqual(true, ProdOrder.ValidationFlag,"Test is failed");

        }

        [TestMethod][TestCategory("Memebership Rule")]
        public void MemeberShipRuleCheck()
        {
            ProductOrderDeatils ProdOrder = new ProductOrderDeatils();
            ProdOrder.OrderNumber = 1;
            ProdOrder.PaymentDesc = "none";
            ProdOrder.PaymentType = PaymentDetail.PaymentTypes.MemebershipActPayment.ToString();
            ProdOrder.cutomerID = 101;


            PaymnetTypeRule PaymentRule = new PaymnetTypeRule();
            PaymentRule.MemeberShipPaymentRule(ProdOrder);
            Assert.AreEqual(true, ProdOrder.ValidationFlag, "Test is failed");

        }
    }
}
