using System.Web.Mvc;
using tw.lib.Models;
using tw.lib.Util;
using Umbraco.Web.Mvc;

namespace tw.lib.Controllers
{
    [PluginController("TvorbaWebu")]
    public class TvorbaWebuController : _BaseController
    {
        public ActionResult Index()
        {
            return View("ContactForm", new TvorbaWebuModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HandleFormSubmit(TvorbaWebuModel model)
        {
            if (ModelState.IsValid)
            {
                if (!new ApiKeyValidator().IsValid(model.Password, model.ConfirmPassword))
                {
                    ModelState.AddModelError("", "Musíte označiť, že nie ste robot.");
                }
            }

            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            model.SendContactRequest();

            return this.RedirectToTvorbaWebuUmbracoPage(ConfigurationUtil.TvorbaWebu_ThankYou_PageId);
        }
    }
}
