using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class PlanesController : Controller
    {
        // GET: Planes
        public ActionResult Index()
        {
            IEnumerable<mvcEmpresaModel> empList2;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Planes").Result;
            empList2 = response.Content.ReadAsAsync<IEnumerable<mvcEmpresaModel>>().Result;
            return View(empList2);
        }
    }
}