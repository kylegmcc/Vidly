using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customer = new List<Customer>()
            {
                new Customer { Name = "Regenald", Id = 2},
                new Customer { Name = "Samantha", Id = 1}
            };

            var viewModel = new CustomersViewModel()
            {
                Customers = customer
            };

            return View(viewModel);
        }

        [Route("customers/details/{id}/{name}")]
        public ActionResult Details(int id, string name)
        {
            var _selectedCustomer = new Customer() { Name = name, Id = id };

            return View(_selectedCustomer);
        }
    }
}
