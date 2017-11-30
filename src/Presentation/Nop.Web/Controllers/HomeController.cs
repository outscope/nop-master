using System.Web.Mvc;
using Nop.Web.Framework.Security;

namespace Nop.Web.Controllers
{
    public partial class HomeController : BasePublicController
    {
        [NopHttpsRequirement(SslRequirement.No)]
        public virtual ActionResult Index()
        {
            //todo: njkhanh test _ redirect về admin
            return Redirect("/Admin");

            return View();
        }
    }
}
