using JewelleryStore.Contract;

namespace JewelleryStore.Models
{
    public class Gold : IJewellery
    {
        public Gold()
        {

        }
        public Gold(double price, double weight)
        {
            Price = price;
            Weight = weight;
        }
        public double Price { get; set; }
        public double Weight { get; set; }
    }
}
