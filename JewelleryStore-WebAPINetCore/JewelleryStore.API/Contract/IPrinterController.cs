using JewelleryStore.Printer.Enums;
using System.Threading.Tasks;

namespace JewelleryStore
{
    public interface IPrinterController
    {
        Task<object> Print(PrinterType printerType, object data);
    }
}
