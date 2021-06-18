using JewelleryStore.Business.Contract;
using JewelleryStore.Contract;
using JewelleryStore.Data.Contracts;
using JewelleryStore.Models;
using System;
using System.Threading.Tasks;

namespace JewelleryStore.SDK
{
    public class PriceCalculatorService : IPriceCalculatorService
    {
        private readonly ICustomerRepository _customerRepository;
        public PriceCalculatorService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<double> CalculatePriceForCustomer(Guid customerId, IJewellery jewellery)
        {
            var customer = await _customerRepository.GetCustomerById(customerId);
            var totalPrice = jewellery.Price * jewellery.Weight;
            if (customer is PrevilegedCustomer)
            {
                var previlegedCustomer = customer as PrevilegedCustomer;
                totalPrice = totalPrice - (totalPrice * (previlegedCustomer.Discount / 100));
            }
            return totalPrice;
        }
    }
}
