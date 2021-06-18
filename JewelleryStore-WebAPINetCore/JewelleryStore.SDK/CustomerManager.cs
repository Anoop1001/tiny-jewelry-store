using JewelleryStore.Business.Contract;
using JewelleryStore.Contract.Customer;
using JewelleryStore.Data;
using JewelleryStore.Data.Contracts;
using JewelleryStore.Models;
using System;
using System.Threading.Tasks;

namespace JewelleryStore.Business
{
    public class CustomerManager : ICustomerManager
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerCredentials> Login(CustomerLoginModel customerLogin)
        {
            var customerDetails = await _customerRepository.CheckIfCredentialsValid(customerLogin.Name, customerLogin.Password);
            if(customerDetails == null)
            {
                throw new ArgumentException("Invalid Credentials Entered");
            }
            return customerDetails;
        }

        public async Task<ICustomer> GetCustomer(Guid customerId)
        {
            return await _customerRepository.GetCustomerById(customerId);
        }
    }
}
