using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EglantineCMS.Controllers
{
    public class SearchController : Controller
    {
        private IPageRepository pageRepository;
        EglantineCMSContext db = new EglantineCMSContext();

        public SearchController()
        {
            pageRepository = new PageRepository(db);
        }
        // GET: Search
        public ActionResult Index(string q)
        {
            ViewBag.Name = q;
            return View(pageRepository.SearchPage(q));
        }
    }
}