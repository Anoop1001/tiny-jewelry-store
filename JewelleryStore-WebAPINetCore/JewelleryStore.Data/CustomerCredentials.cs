using JewelleryStore.Models.Enums;
using System;

namespace JewelleryStore.Data
{
    public class CustomerCredentials
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Category Category { get; set; }
    }
}
