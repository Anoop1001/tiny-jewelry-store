using JewelleryStore.Contract.Customer;
using System;
using System.Threading.Tasks;

namespace JewelleryStore.Data.Contracts
{
    public interface ICustomerRepository
    {
        Task<CustomerCredentials> CheckIfCredentialsValid(string name, string password);
        Task<ICustomer> GetCustomerById(Guid customerId);
    }
}
