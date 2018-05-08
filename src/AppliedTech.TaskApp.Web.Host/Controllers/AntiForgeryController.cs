using Microsoft.AspNetCore.Antiforgery;
using AppliedTech.TaskApp.Controllers;

namespace AppliedTech.TaskApp.Web.Host.Controllers
{
    public class AntiForgeryController : TaskAppControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
