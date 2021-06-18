using JewelleryStore.Printer.Contract;
using JewelleryStore.Printer.Enums;

namespace JewelleryStore.Printer
{
    /*
     * Simple factory class to Get Customer
     */
    public class PrinterFactory
    {
        public static IPrinter CreatePrinter(PrinterType type)
        {
            switch (type)
            {
                case PrinterType.File: return FilePrinter.Printer;
                case PrinterType.OnScreen: return ScreenPrinter.Printer;
                case PrinterType.Printer: return DevicePrinter.Printer;
                default: return null;
            }
        }
    }
}
