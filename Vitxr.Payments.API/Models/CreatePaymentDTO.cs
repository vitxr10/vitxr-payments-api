namespace Vitxr.Payments.API.Models
{
    public class CreatePaymentDTO
    {
        public string Customer { get; set; }
        public string BillingType { get; set; }
        public decimal Value { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
    }
}
