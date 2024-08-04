namespace Vitxr.Payments.API.Models
{
    public class CreateCustomerDTO
    {
        public string Name { get; set; }
        public string CpfCnpj { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
    }
}
