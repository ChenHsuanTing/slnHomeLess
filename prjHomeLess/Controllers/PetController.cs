using Microsoft.AspNetCore.Mvc;
using prjHomeLess.Models;
using prjHomeLess.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjHomeLess.Controllers
{
    public class PetController : Controller
    {
        public IActionResult List()
        {
            我救浪Context db = new 我救浪Context();
            var datas = from p in db.Products
                        where p.IsPet == true
                        select p;
            List<CPet> list = new List<CPet>();
            foreach(Product p in datas)
            {
               CPet pet = new CPet();
                pet.Product = p;
                list.Add(pet);
            }
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            我救浪Context db = new 我救浪Context();

            db.Products.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
