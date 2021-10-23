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
        public static HttpClient WebApiClient = new HttpClient();
        // GET: Empresas
        public ActionResult Index()
        {
            WebApiClient.BaseAddress = new Uri("https://localhost:44398/api/");
            IEnumerable<mvcEmpresaModel> empList;
            HttpResponseMessage response = WebApiClient.GetAsync("Empresas").Result;
            WebApiClient.DefaultRequestHeaders.Accept.Clear();
            WebApiClient.DefaultRequestHeaders.Add("Accept", "application/json;odata=verbose");
            empList = response.Content.ReadAsAsync<IEnumerable<mvcEmpresaModel>>().Result;
            return View(empList);

        }
    }
}