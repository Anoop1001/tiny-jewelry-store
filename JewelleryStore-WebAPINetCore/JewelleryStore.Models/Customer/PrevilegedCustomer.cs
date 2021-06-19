using JewelleryStore.Contract;
using JewelleryStore.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace JewelleryStore.Models
{
    public class PrevilegedCustomer : Customer, IPrevilege
    {
        public double Discount { get; set; }
        public PrevilegedCustomer()
        {
            Discount = 2;
        }
        [JsonConverter(typeof(JsonStringEnumConverter))]

        public override Category Category { get { return Category.Previleged; } }


        public void SetDiscount(double discount)
        {
            Discount = discount;
        }
    }
}
