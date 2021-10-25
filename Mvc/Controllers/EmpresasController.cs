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
            if (id == 0) 
            {
                return View(new mvcEmpresaModel());
            }
            else 
            {
                HttpResponseMessage response = WebApiClient.GetAsync("Empresas/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcEmpresaModel>().Result);
            }
        }
        [HttpPost]
        public ActionResult AgregaroEditar(mvcEmpresaModel emp)
        {
            if (emp.IdEmpresa == 0) 
            {
                HttpResponseMessage response = WebApiClient.PostAsJsonAsync("Empresas", emp).Result;
                TempData["SuccessMessage"] = "Empresa Guardada.";
            }
            else 
            {
                HttpResponseMessage response = WebApiClient.PutAsJsonAsync("Empresas/" + emp.IdEmpresa, emp).Result;
                TempData["SuccessMessage"] = "Cambios Guardados.";
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id = 0) 
        {
            HttpResponseMessage response = WebApiClient.DeleteAsync("Empresas/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Empresa Borrada.";
            return RedirectToAction("Index");
        }
    }
}