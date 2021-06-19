using JewelleryStore.Contract;
using JewelleryStore.Data;
using JewelleryStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace JewelleryStore
{
    public interface ICustomerController
    {
        Task<CustomerCredentials> Login(CustomerLoginModel CustomerLogin);
        Task<double> CalculatePrice([FromRoute] Guid customerId, Gold jewellery);
    }
}
