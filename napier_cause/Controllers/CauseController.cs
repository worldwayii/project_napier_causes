using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using AuthorizeAttribute = System.Web.Http.AuthorizeAttribute;

namespace napier_cause.Controllers
{
    [Authorize]
    public class CauseController : Controller
    {
        
        public ActionResult Create()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}
