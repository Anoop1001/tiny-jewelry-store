using JewelleryStore.Contract;
using JewelleryStore.Contract.Customer;
using JewelleryStore.Models;
using JewelleryStore.Models.Enums;

namespace JewelleryStore
{
    /*
     * Simple factory class to Get Jewellery
     */
    public class JewelleryFactory
    {
        public static IJewellery CreateGoldJewellery()
        {
            return new Gold();
        }

        public static IJewellery CreateGoldJewellery(double price, double weight)
        {
            return new Gold(price, weight);
        }
    }
}
