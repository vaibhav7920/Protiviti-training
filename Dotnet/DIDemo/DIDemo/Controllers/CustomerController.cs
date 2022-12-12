using DIDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemo.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> cst = new List<Customer>();
            Customer customer = new Customer();
            customer.custid = 1;
            customer.name = "Vaibhav";
            customer.age = 22;

            Customer customer1 = new Customer();
            customer1.custid = 2;
            customer1.name = "ABC";
            customer1.age = 22;

            cst.Add(customer);
            cst.Add(customer1);

            return View(cst);
        }


        public IActionResult Details()
        {
               return View();
        }


        public IActionResult Contact()
        {
            return View();
        }



    }
}
