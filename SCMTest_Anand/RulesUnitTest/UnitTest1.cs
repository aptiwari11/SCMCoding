using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCMTest_Anand;
using SCMTest_Anand.Rules;

namespace RulesUnitTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {
            ProductOrderDeatils ProdOrder = new ProductOrderDeatils();
            ProdOrder.OrderNumber = 1;
            ProdOrder.PaymentDesc = "Learning To Ski";
            ProdOrder.PaymentType = PaymentDetail.PaymentTypes.VideoPayment.ToString();

            PaymnetTypeRule PaymentRule = new PaymnetTypeRule();
            PaymentRule.RuleExcute(ProdOrder);
            Assert.AreEqual(true, ProdOrder.ValidationFlag,"Test is failed");

        }
    }
}
