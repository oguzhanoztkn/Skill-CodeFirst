using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_CodeFirst.Models.Siniflar;
namespace Skill_CodeFirst.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
         
            var degerler = c.Yeteneklers.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(Yetenekler y)
        {
            c.Yeteneklers.Add(y);
            c.SaveChanges();
           
            return View();
        }
        public ActionResult YetenekSil(int id)
        {
            var degerler = c.Yeteneklers.Find(id);
            c.Yeteneklers.Remove(degerler);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekGetir(int id)
        {
            var degerler = c.Yeteneklers.Find(id);

            return View(degerler);
        }
        [HttpPost]
        public ActionResult YetenekGetir(Yetenekler y)
        {
            var x = c.Yeteneklers.Find(y.Id);
            x.YetenekAciklama = y.YetenekAciklama;
            x.Deger = y.Deger;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}