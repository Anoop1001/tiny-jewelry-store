using JewelleryStore.Printer.Enums;

namespace JewelleryStore.Printer.Contract
{
    public interface IPrinter
    {
        T Print<T>(T data);
    }
}
