using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Menu()
        {
            var items = _context.Items.ToList();
            var catigories = _context.Categories.ToList();
            var itemsToShowCount = 5;

            ItemsViewModel itemsViewModel = new ItemsViewModel(items, catigories, itemsToShowCount);

            return View(itemsViewModel);
        }


        public ActionResult Checkout()
        {
            return View();
        }
        
        
    }
}