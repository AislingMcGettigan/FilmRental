using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental.Models;
using MovieRental.ViewModels;

namespace MovieRental.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>()
            {
                new Customer(){Name ="John Smith" , Id=1},
                new Customer(){Name = "Mary Williams", Id=2}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (id == 1)
            {
                return Content("John Smith");
            }

            if (id == 2)
            {
                return Content("Mary Williams");
            }

            return Content("Unknown");
        }
    }
}