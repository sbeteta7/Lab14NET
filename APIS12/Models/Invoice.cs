namespace APIS12.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }

        public DateTime Date { get; set; }

        public string InvoiceNumber { get; set; }

        public float Total { get; set; }

        public Boolean Active { get; set; }

        public int customerID { get; set; }

        public Customer customer { get; set; }

    }
}
