using PagedList;
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
        private SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();

        // GET: Money
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult List(int page = 1)
        {
            var Accountdata = db.AccountBook.OrderBy(x => x.Dateee).ToPagedList(page, 10);
            return View(Accountdata);
        }
    }
}