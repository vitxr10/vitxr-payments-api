﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vitxr.Payments.API.Models;
using Vitxr.Payments.API.Services.Interfaces;

namespace Vitxr.Payments.API.Controllers
{
    [Route("api/payments")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreatePaymentDTO payment)
        {
            try
            {
                var invoiceUrl = await _paymentService.CreatePayment(payment);

                return Ok(invoiceUrl);
            }
            catch (Exception ex)
            {
                return BadRequest("Não foi possível gerar o pagamento." + ex);
            }
        }

        [HttpPost("customer")]
        public async Task<IActionResult> Post(CreateCustomerDTO customer)
        {
            try
            {
                var invoiceUrl = await _paymentService.CreateCustomer(customer);

                return Ok(invoiceUrl);
            }
            catch (Exception ex)
            {
                return BadRequest("Não foi possível gerar o cliente." + ex);
            }
        }
    }
}
