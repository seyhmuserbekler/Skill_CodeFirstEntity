using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_CodeFirstEntity.Models.siniflar;
namespace Skill_CodeFirstEntity.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        CONTEXT db = new CONTEXT(); 
        public ActionResult Index()
        {
            var degerler=db.YETENEKLERS.ToList();
            return View(degerler);
        }
    }
}