using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using MiroslavPodmajerskyUmbracoOsobnaStranka.lib.Models;
using Umbraco.Web.Mvc;

namespace MiroslavPodmajerskyUmbracoOsobnaStranka.lib.Controllers
{
    [PluginController("OsobnaStranka")]
    public class ContactController : _BaseController
    {
        public ActionResult Index()
        {
            return View("ContactForm", new OsobnaStrankaContactModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HandleFormSubmit(OsobnaStrankaContactModel model)
        {
           
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            TempData["success"] = model.SendContactRequest();

            return RedirectToCurrentUmbracoPage();
        }
    }
}
