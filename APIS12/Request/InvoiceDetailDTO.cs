namespace APIS12.Request
{
    public class InvoiceDetailDTO
    {
        public string InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public float Total { get; set; }
        public CustomerDTO Customer { get; set; }
        public List<DetailDTO> Details { get; set; }
    }
}
