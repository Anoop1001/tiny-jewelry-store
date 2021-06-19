using JewelleryStore.Business.Contract;
using JewelleryStore.Contract;
using JewelleryStore.Contract.Customer;
using JewelleryStore.Data;
using JewelleryStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace JewelleryStore
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase, ICustomerController
    {
        private readonly ICustomerManager _customerManager;
        private readonly IPriceCalculatorService _priceCalculatorService;
        public CustomerController(ICustomerManager customerManager, IPriceCalculatorService priceCalculatorService)
        {
            _customerManager = customerManager;
            _priceCalculatorService = priceCalculatorService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<CustomerCredentials> Login([FromBody] CustomerLoginModel customerLogin)
        {
            return await _customerManager.Login(customerLogin);
        }


        [HttpPost]
        [Route("price/{customerId:Guid}")]
        public async Task<double> CalculatePrice([FromRoute] Guid customerId, Gold jewellery)
        {
            return await _priceCalculatorService.CalculatePriceForCustomer(customerId, jewellery);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<ICustomer> GetCustomer([FromRoute] Guid id)
        {
            return await _customerManager.GetCustomer(id);
        }
    }
}
