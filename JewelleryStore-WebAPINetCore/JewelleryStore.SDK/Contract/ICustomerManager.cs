using JewelleryStore.Contract.Customer;
using JewelleryStore.Data;
using JewelleryStore.Models;
using System;
using System.Threading.Tasks;

namespace JewelleryStore.Business.Contract
{
    public interface ICustomerManager
    {
        Task<CustomerCredentials> Login(CustomerLoginModel CustomerLogin);
        Task<ICustomer> GetCustomer(Guid customerId);
    }
}
