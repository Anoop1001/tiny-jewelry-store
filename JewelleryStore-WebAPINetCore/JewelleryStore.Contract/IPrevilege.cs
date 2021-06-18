using JewelleryStore.Contract.Customer;

namespace JewelleryStore.Contract
{
    public interface IPrevilege
    {
        double Discount { get; set; }
        void SetDiscount(double discount);
    }
}
