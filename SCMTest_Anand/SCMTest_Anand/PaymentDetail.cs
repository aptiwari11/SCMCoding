namespace SCMTest_Anand
{
    internal class PaymentDetail
    {
        public string PaymentType { get; set; }
        public string PaymentDesc { get; set; }


        public enum PaymentTypes
        {
            PhysicalProduct,
            BookPayment,
            MemebershipActPayment,
            MemebershipUpPayment,
            VideoPayment

        }

    }
}