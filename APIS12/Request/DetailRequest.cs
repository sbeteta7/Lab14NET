namespace APIS12.Request
{
    public class DetailRequest
    {
        public int Amount { get; set; }
        public float Price { get; set; }
        public float SubTotal { get; set; }
        public bool Active { get; set; }
        public int ProductID { get; set; }
        public int InvoiceID { get; set; }
    }
}
