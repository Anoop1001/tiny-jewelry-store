using System;

namespace JewelleryStore.Contract.Customer
{
    public interface ICustomer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

    }
}
