using JewelleryStore.Contract;
using System;
using System.Threading.Tasks;

namespace JewelleryStore.Business.Contract
{
    public interface IPriceCalculatorService
    {
        Task<double> CalculatePriceForCustomer(Guid customerId, IJewellery jewellery);
    }
}
