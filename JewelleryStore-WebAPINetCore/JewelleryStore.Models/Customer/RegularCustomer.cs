using JewelleryStore.Models.Enums;

namespace JewelleryStore.Models
{
    public class RegularCustomer : Customer
    {
        public override Category Category { get { return Category.Regular; } }
    }
}
