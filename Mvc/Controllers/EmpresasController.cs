using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class EmpresasController : Controller
    {
        // GET: Empresas
        public ActionResult Index()
        {
            IEnumerable<mvcEmpresaModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Empresas").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<mvcEmpresaModel>>().Result;
            return View(empList);
        }
    }
}