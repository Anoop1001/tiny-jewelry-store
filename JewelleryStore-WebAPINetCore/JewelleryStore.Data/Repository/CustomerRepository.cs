using JewelleryStore.Contract.Customer;
using JewelleryStore.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelleryStore.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task<CustomerCredentials> CheckIfCredentialsValid(string name, string password)
        {
            var listOfValidCustomers = GetListOfValidCustomers();
            var customer = listOfValidCustomers.FirstOrDefault(x => x.Name == name && x.Password == password);

            return await Task.FromResult(customer);
        }

        public async Task<ICustomer> GetCustomerById(Guid customerId)
        {
            var listOfValidCustomers = GetListOfValidCustomers();
            var customerFromDb = listOfValidCustomers.FirstOrDefault(x => x.Id == customerId);
            var customer = CustomerFactory.CreateCustomer(customerFromDb.Category);
            customer.Id = customerFromDb.Id;
            customer.Name = customerFromDb.Name;
            return await Task.FromResult(customer);
        }

        private static IEnumerable<CustomerCredentials> GetListOfValidCustomers()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<CustomerCredentials>>(DataSource.CredentialData);
        }
    }
}
