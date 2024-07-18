using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shop.Controllers
{
    public class HomeController : Controller
    {
        ProductRepository productRepository = new ProductRepository();
        //DataContext db = new DataContext();

        public ActionResult Index(int sayfa=1)
        {
            return View(productRepository.GetProductList().ToPagedList(sayfa, 3));
        }
        //public ActionResult Index(int sayfa = 1)
        //{
        //    var product = productRepository.GetPopularProduct();
        //    ViewBag.popular = product;
        //}
    }
}