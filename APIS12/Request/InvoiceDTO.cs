namespace APIS12.Request
{
    public class InvoiceDTO
    {
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public float Total { get; set; }
        public Boolean Active { get; set; }
    }
}
