using APIS12.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIS12.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        // llamamos a nuestro contexo
        private readonly InvoiceContext _invoiceContext;

        public ProductController(InvoiceContext invoiceContext)
        {
            _invoiceContext = invoiceContext;
        }

        // method list product where status is true
        [HttpGet]
        public List<Product> getAllProduct()
        {
            return _invoiceContext.Products.Where(x => x.Active == true).ToList();
        }

        // method create new product
        [HttpPost]
        public void InsertProduct(Product product)
        {
            _invoiceContext.Products.Add(product);
            _invoiceContext.SaveChanges();
        }

        // logic delete
        [HttpPost]
        public void DeleteProduct(int productID)
        {
            _invoiceContext.Products.Find(productID).Active = false;
            _invoiceContext.SaveChanges();
        }

    }
}
