using JewelleryStore.Contract.Customer;
using JewelleryStore.Models.Enums;
using System;

namespace JewelleryStore.Models
{
    /*
     * Abstract class for both the types of customer since the common members can be reused
     */
    public abstract class Customer : ICustomer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual Category Category { get; set; }
    }
}
