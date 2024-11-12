namespace APIS12.Models
{
    public class Detail
    {
        public int DetailID { get; set; }
        public int Amount { get; set; }

        public float Price { get; set; }

        public float SubTotal { get; set; }

        public Boolean Active { get; set; }

        public int productID { get; set; }

        public int invoiceID { get; set; }

        public Product product { get; set; }

        public Invoice invoice { get; set; }


    }
}
