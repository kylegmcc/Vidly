using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            var viewModel = new CustomersViewModel()
            {
                Customers = customers
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
