using PSS.Areas.入库管理.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSS.Areas.入库管理.Controllers
{
    public class RKGLController : Controller
    {
        private PSSEntities db = new PSSEntities();
        // GET: 入库管理/RKGL
        public ActionResult RKAdd()
        {
            return View();
        }
        public ActionResult NewID() {
            var id = db.v_InDepot.ToList().OrderByDescending(x => x.InNo).First();
            return View();
        }
    }
}