namespace APIS12.Request
{
    public class InvoiceRequestI
    {

        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public float Total { get; set; }
        public int customerID { get; set; }
    }
}
