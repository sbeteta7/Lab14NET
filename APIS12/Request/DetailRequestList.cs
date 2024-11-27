namespace APIS12.Request
{
    public class DetailRequestList
    {
        public int InvoiceID { get; set; }

        public List<DetailDTO> Details { get; set; }
    }
}
