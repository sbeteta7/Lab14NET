using APIS12.Models;
using APIS12.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

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

        [HttpGet]
        public List<Customer> getAllCustomer()
        {
            return _invoiceContext.Customers.Where(x => x.Active == true).ToList();
        }

        [HttpPost]
        public void InsertCustomer(CustomerRequestI request)
        {
            Customer customer = new Customer()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                DocumentNumber = request.DocumentNumber,
                Active = true
            };

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

        [HttpPost]
        public void deleteCustomer(CustomerRequestD request)
        {
            _invoiceContext.Customers.Find(request.CustomerID).Active = false;
            _invoiceContext.SaveChanges();
        }

        [HttpPut]
        public void UpdateNumberDoc(RequestUpdateDoc  request)
        {
            Customer customer = _invoiceContext.Customers.Where(x => x.CustomerID == request.CustomerID).FirstOrDefault();

            customer.DocumentNumber = request.DocumentNumber;

            _invoiceContext.Entry(customer).State = EntityState.Modified;
            _invoiceContext.SaveChanges();
        }


        [HttpPost]
        public List<Customer> getCustomerByCriteria(CustomerRequestV1 customerRequest)
        {
            //var query = _invoiceContext.Customers.Where(x => x.Active == true);
            var query = _invoiceContext.Customers.Where(x => x.Active);

            if (!string.IsNullOrEmpty(customerRequest.firstName))
            {
                query = query.Where(x => x.FirstName.Contains(customerRequest.firstName));
            }

            if (!string.IsNullOrEmpty(customerRequest.lastName))
            {
                query = query.Where(x => x.LastName.Contains(customerRequest.lastName));
            }

       
            
            return query.OrderByDescending(x => x.LastName).ToList();

        }



    }
}
