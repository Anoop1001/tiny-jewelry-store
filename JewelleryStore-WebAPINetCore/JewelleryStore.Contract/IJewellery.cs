namespace JewelleryStore.Contract
{
    /*
     * This interface can be implemented for different types of Jewels like Gold, Silver, Platinum etc.
     */
    public interface IJewellery
    {
        public double Price { get; set; }
        public double Weight { get; set; }
    }
}
