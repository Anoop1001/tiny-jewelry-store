using JewelleryStore.API;
using JewelleryStore.Business;
using JewelleryStore.Printer.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace JewelleryStore.Tests
{
    [TestClass]
    public class JewelleryStorePrinterTest
    {
        private readonly PrinterController printerController;
        private readonly PrinterService printerService;
        public JewelleryStorePrinterTest()
        {
            printerService = new PrinterService();
            printerController = new PrinterController(printerService);
        }
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public async Task Print_When_Printer_Device_ThowsException()
        {
            var data = await printerController.Print(PrinterType.Printer, 1000);
            Assert.AreEqual(data, 1000);
        }

        [TestMethod]
        public async Task Print_When_Printer_OnScreen_Prints_And_ReturnsData()
        {
            var data = await printerController.Print(PrinterType.OnScreen, 1000);
            Assert.AreEqual(data, 1000);
        }

        [TestMethod]
        public async Task Print_When_Printer_File_Prints_And_ReturnsData()
        {
            var data = await printerController.Print(PrinterType.File, 1000);
            Assert.AreEqual(data, 1000);
        }
    }
}
