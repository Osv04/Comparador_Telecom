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
            if (WebApiClient.BaseAddress == null)
            {
                WebApiClient.BaseAddress = new Uri("https://localhost:44398/api/");
            }
            IEnumerable<mvcEmpresaModel> empList;
            HttpResponseMessage response = WebApiClient.GetAsync("Empresas").Result;
            WebApiClient.DefaultRequestHeaders.Accept.Clear();
            WebApiClient.DefaultRequestHeaders.Add("Accept", "application/json;odata=verbose");
            empList = response.Content.ReadAsAsync<IEnumerable<mvcEmpresaModel>>().Result;
            return View(empList);
        }

        public ActionResult AgregaroEditar(int id = 0)
        {
            return View(new mvcEmpresaModel());

        }
        [HttpPost]
        public ActionResult AgregaroEditar(mvcEmpresaModel emp)
        {
            HttpResponseMessage response = WebApiClient.PostAsJsonAsync("Empresas",emp).Result;
            //TempData["SuccessMessage"] = "Saved Successfully";
            return RedirectToAction("Index");
        }
    }
}