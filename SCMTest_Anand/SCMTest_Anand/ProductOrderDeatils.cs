using System;
using System.Collections.Generic;
using System.Text;

namespace SCMTest_Anand
{
    public class ProductOrderDeatils : PaymentDetail
    {
        //This class will have the information about Order and it's payment type.
        public int OrderNumber { get; set; }

        public int cutomerID { get; set; }

        List<PaymentDetail> paymentDetails { get; set; }
        public bool ValidationFlag { get; set; }
        public string ValidationError { get; set; }
        public List<string> Miscellaneous { get; set; }
        public bool PackingSlip { get; set; }
        public int AgentComm { get; set; }
        public int TotalOrderCost { get; set; }
        public int AgentCommPer{get; set;}
        
    }
}
