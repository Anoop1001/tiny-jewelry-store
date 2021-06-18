using JewelleryStore.Common;
using JewelleryStore.Printer.Contract;
using JewelleryStore.Printer.Enums;
using Newtonsoft.Json;
using System.IO;

namespace JewelleryStore.Printer
{
    public class FilePrinter : IPrinter
    {
        private static FilePrinter printer;
        public string FilePath { get; set; }
        private FilePrinter()
        {
            FilePath = $"{DirectoryPath.AssemblyDirectory}\\file.txt";
        }
        public static IPrinter Printer
        {
            get
            {
                if (printer == null)
                {
                    printer = new FilePrinter();
                }
                return printer;
            }
        }
        public T Print<T>(T data)
        {
            string dataToPrint = JsonConvert.SerializeObject(data);
            File.WriteAllText(FilePath, dataToPrint);
            return data;
        }
    }
}
