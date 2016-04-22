using SkillTree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillTree.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult List()
        {
            return View();
        }
    }
}