using JewelleryStore.Business.Contract;
using JewelleryStore.Printer.Enums;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading.Tasks;

namespace JewelleryStore.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrinterController : ControllerBase, IPrinterController
    {
        private readonly IPrinterService _printerService;
        public PrinterController(IPrinterService printerService)
        {
            _printerService = printerService;
        }

        [HttpPost]
        [Route("print/printerType")]
        [SwaggerOperation(Tags = new[] { "Subscribers"})]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(object))]
        public async Task<object> Print(PrinterType printerType, object data)
        {
            return await _printerService.PrintData(printerType, data);
        }
    }
}
