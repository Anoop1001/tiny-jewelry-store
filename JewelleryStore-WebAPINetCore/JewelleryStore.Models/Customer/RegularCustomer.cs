using JewelleryStore.Models.Enums;
using System.Text.Json.Serialization;

namespace JewelleryStore.Models
{
    public class RegularCustomer : Customer
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public override Category Category { get { return Category.Regular; } }
    }
}
