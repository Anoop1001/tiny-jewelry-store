using JewelleryStore.Printer.Contract;
using JewelleryStore.Printer.Enums;
using System;

namespace JewelleryStore.Printer
{
    public class DevicePrinter : IPrinter
    {
        private static DevicePrinter printer;
        private DevicePrinter()
        {

        }
        public static IPrinter Printer
        {
            get
            {
                if (printer == null)
                {
                    printer = new DevicePrinter();
                }
                return printer;
            }
        }
        public T Print<T>(T data)
        {
            throw new NotImplementedException();
        }
    }
}
