using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace BlazorSamplePDF.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadsController : ControllerBase
    {
        private readonly IInvoiceService invoiceService;

        public DownloadsController(IInvoiceService invoiceService)
        {
            this.invoiceService = invoiceService;
        }

        [HttpGet("invoice")]
        public IActionResult GetInvoice()
        {
            var invoice = invoiceService.GenerateInvoice();
            return File(invoice, MediaTypeNames.Application.Pdf, "invoice.pdf");
        }
    }
}
