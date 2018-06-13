using Library_AjaxLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_AjaxLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BooksByAuthor()
        {
            return View();
        }

        public ActionResult BooksByTitle()
        {          

            return View();
        }

        public ActionResult BooksByYear()
        {           

            return View();
        }

        public ActionResult GetBooksByAuthor(string author)
        {
            LibraryEntities db = new LibraryEntities();

            //LINQ version:
            /*List<Customer> list = (
                from c in db.Customers
                where c.City == city
                select c
                ).ToList();*/
            //exact same thing in a Lambda expression
            /*List<Customer> list = db.Customers.Where(
                c=>c.City.Equals(city)
                ).ToList();*/
            List<book> list = db.books.Where(
               b => b.Author.Contains(author)
                ).ToList();

            return Json(list);
        }

        public ActionResult GetBooksByTitle(string title)
        {
            LibraryEntities db = new LibraryEntities();

            //LINQ version:
            /*List<Customer> list = (
                from c in db.Customers
                where c.City == city
                select c
                ).ToList();*/
            //exact same thing in a Lambda expression
            /*List<Customer> list = db.Customers.Where(
                c=>c.City.Equals(city)
                ).ToList();*/
            List<book> list = db.books.Where(
               b => b.Title.Contains(title)
                ).ToList();

            return Json(list);
        }

        public ActionResult GetBooksByYear(int? year)
        {
            LibraryEntities db = new LibraryEntities();

            //LINQ version:
            /*List<Customer> list = (
                from c in db.Customers
                where c.City == city
                select c
                ).ToList();*/
            //exact same thing in a Lambda expression
            /*List<Customer> list = db.Customers.Where(
                c=>c.City.Equals(city)
                ).ToList();*/
            List<book> list = db.books.Where(
               b => b.YearPublished == year
                ).ToList();

            return Json(list);
        }
    }
}