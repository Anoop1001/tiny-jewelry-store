using JewelleryStore.Printer.Contract;

namespace JewelleryStore.Printer
{
    public class ScreenPrinter : IPrinter
    {
        private static ScreenPrinter printer;
        private ScreenPrinter()
        {

        }
        public static IPrinter Printer
        {
            get
            {
                if (printer == null)
                {
                    printer = new ScreenPrinter();
                }
                return printer;
            }
        }
        public T Print<T>(T data)
        {
            return data;
        }
    }
}
