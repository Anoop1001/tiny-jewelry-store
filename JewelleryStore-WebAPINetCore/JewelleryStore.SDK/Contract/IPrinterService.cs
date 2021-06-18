using JewelleryStore.Printer.Enums;
using System.Threading.Tasks;

namespace JewelleryStore.Business.Contract
{
    public interface IPrinterService
    {
        Task<T> PrintData<T>(PrinterType printerType, T data);
    }
}
