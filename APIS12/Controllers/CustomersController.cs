using APIS12.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIS12.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        private readonly InvoiceContext _invoiceContext;

        public CustomersController(InvoiceContext invoiceContext)
        {
            _invoiceContext = invoiceContext;
        }

        // method list customer
        [HttpGet]
        public List<Customer> getAllCustomer()
        {
            //return _invoiceContext.Customers.ToList();
            return _invoiceContext.Customers.Where(x => x.Active == true).ToList();
        }

        // method create customer
        [HttpPost]
        public void InsertCustomer(Customer customer)
        {
            _invoiceContext.Customers.Add(customer);
            _invoiceContext.SaveChanges();
        }

        // method update customer
        /*
        [HttpPut]
        public void UpdateCustomer(int customerID, Customer customer)
        {
            if (customerID != customer.CustomerID)
            {
                BadRequest();
            }
            _invoiceContext.Entry(customer).State = EntityState.Modified;
            _invoiceContext.SaveChanges();
        }

        */

        // delete logic
        [HttpPost]
        public void deleteCustomer(int customerID)
        {
            _invoiceContext.Customers.Find(customerID).Active = false;
            _invoiceContext.SaveChanges();
        }


    }
}
