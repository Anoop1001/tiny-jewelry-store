using JewelleryStore.Contract.Customer;
using JewelleryStore.Models;
using JewelleryStore.Models.Enums;

namespace JewelleryStore
{
    /*
     * Simple factory class to Get Customer
     */
    public class CustomerFactory
    {
        public static ICustomer CreateCustomer(Category category)
        {
            switch (category)
            {
                case Category.Regular: return new RegularCustomer();
                case Category.Previleged: return new PrevilegedCustomer();
                default: return null;
            }
        }
    }
}
