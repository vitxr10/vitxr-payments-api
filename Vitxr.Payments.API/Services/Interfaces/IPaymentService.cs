using Vitxr.Payments.API.Models;

namespace Vitxr.Payments.API.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<string> CreatePayment(CreatePaymentDTO payment);
        Task<string> CreateCustomer(CreateCustomerDTO customer);
    }
}
