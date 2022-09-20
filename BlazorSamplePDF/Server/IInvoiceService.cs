namespace BlazorSamplePDF.Server
{
    public interface IInvoiceService
    {
        byte[] GenerateInvoice();
    }
}