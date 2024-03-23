using System.Configuration;
using System.Web;
using Umbraco.Web.Mvc;

namespace tw.lib.Controllers
{
    public class _BaseController : SurfaceController
    {
        public string DefaultImgPath
        {
            get
            {
                return this.HttpContext.Server.MapPath("~/Styles/Images");
            }
        }

        protected RedirectToUmbracoPageResult RedirectToTvorbaWebuUmbracoPage(string pageKey)
        {
            return this.RedirectToUmbracoPage(GetPageId(pageKey));
        }
        protected RedirectToUmbracoPageResult RedirectToTvorbaWebuUmbracoPage(string pageKey, string queryString)
        {
            return this.RedirectToUmbracoPage(GetPageId(pageKey), queryString);
        }

        int GetPageId(string pageKey)
        {
            return int.Parse(ConfigurationManager.AppSettings[pageKey]);
        }
    }

    public class _BaseControllerUtil
    {
        public string CurrentSessionId
        {
            get
            {
                return HttpContext.Current.Session.SessionID;
            }
        }
        public HttpRequest CurrentRequest
        {
            get
            {
                return HttpContext.Current.Request;
            }
        }

        public string SiteRootUrl
        {
            get
            {
                System.Uri uri = this.CurrentRequest.Url;

                return string.Format("{0}://{1}{2}",
                    uri.Scheme,
                    uri.Host,
                    uri.IsDefaultPort ? "" : string.Format(":{0}", uri.Port));
            }
        }
    }
}
