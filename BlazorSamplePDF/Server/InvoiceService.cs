using QuestPDF.Fluent;
using SamplePDF;

namespace BlazorSamplePDF.Server
{
    public class InvoiceService : IInvoiceService
    {
        public byte[] GenerateInvoice()
        {
            var model = InvoiceDocumentDataSource.GetInvoiceDetails();
            var document = new InvoiceDocument(model);

            return document.GeneratePdf();
        }
    }
}
