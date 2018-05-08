using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AppliedTech.TaskApp.Controllers;

namespace AppliedTech.TaskApp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TaskAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
