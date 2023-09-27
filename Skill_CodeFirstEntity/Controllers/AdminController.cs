using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_CodeFirstEntity.Models.siniflar;

namespace Skill_CodeFirstEntity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        CONTEXT db = new CONTEXT(); 
        public ActionResult Index()
        {
            var degerler=db.YETENEKLERS.ToList();
            return View(degerler);
        }


        [HttpGet]
        public ActionResult YeniYetenek( )

        {
            return View();
        }


        [HttpPost]
        public ActionResult YeniYetenek(YETENEKLER y) 
        
        {

        db.YETENEKLERS.Add(y);  // butona tıklanınca listeleme
            db.SaveChanges();
            return View();
        }
        public ActionResult Yeteneksil(int id)
        {
            var deger=db.YETENEKLERS.Find(id);
            db.YETENEKLERS.Remove(deger);   
            db.SaveChanges();   
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult YetenekGetir(int id)
        {
            var deger= db.YETENEKLERS.Find(id);
            return View("YetenekGetir",deger);
           
        }

        [HttpPost]
        public ActionResult YetenekGetir(YETENEKLER y)
        {
            var deger = db.YETENEKLERS.Find(y.ID);
            deger.ACIKLAMA = y.ACIKLAMA;
            deger.DEGER = y.DEGER;  
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
   
}