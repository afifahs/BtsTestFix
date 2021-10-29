using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BtsTest.DataAccess_repo_;

namespace BtsTest.Controllers
{
    public class BtsController : Controller
    {
        private  BtsAttributeRepo _BtsAttributeRepo;


        // GET: Bts
        public ActionResult Index()
        {
            return View();
        }
    }
}