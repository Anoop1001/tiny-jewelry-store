using JewelleryStore.Business.Contract;
using JewelleryStore.Models.Enums;
using JewelleryStore.Printer;
using JewelleryStore.Printer.Enums;
using System.Threading.Tasks;

namespace JewelleryStore.Business
{
    public class PrinterService : IPrinterService
    {
        public async Task<T> PrintData<T>(PrinterType printerType, T data)
        {
            return await Task.FromResult(PrinterFactory.CreatePrinter(printerType).Print(data));
        }
    }
}
