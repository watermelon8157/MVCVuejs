using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCVue.Areas.Components.Controllers
{
    public partial class FormController : Controller
    {
        // GET: Components/Form
        public virtual ActionResult Index()
        {
            return View();
        }
        public virtual ActionResult template()
        {
            return View();
        }

        public virtual ActionResult API()
        {
            return View();
        }
    }
}