using APIS12.Models;

namespace APIS12.Request
{
    public class InvoiceRequestList
    {
        public int CustomerID { get; set; }

        public List<InvoiceDTO> Invoices  { get; set; }
    }
}
