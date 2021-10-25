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
        public static HttpClient WebApiClient = new HttpClient();
        // GET: Planes
        public ActionResult Index()
        {
            if (WebApiClient.BaseAddress == null)
            {
                WebApiClient.BaseAddress = new Uri("https://localhost:44398/api/");
            }         
            IEnumerable<mvcPlanesModel> planList;
            HttpResponseMessage response = WebApiClient.GetAsync("Planes").Result;
            WebApiClient.DefaultRequestHeaders.Accept.Clear();
            WebApiClient.DefaultRequestHeaders.Add("Accept", "application/json;odata=verbose");
            planList = response.Content.ReadAsAsync<IEnumerable<mvcPlanesModel>>().Result;
            return View(planList);
        }

        public ActionResult AgregaroEditarPlanes(int id = 0)
        {
            if (id == 0)
            {
                return View(new mvcPlanesModel());
            }
            else
            {
                HttpResponseMessage response = WebApiClient.GetAsync("Planes/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcPlanesModel>().Result);
            }
        }
        [HttpPost]
        public ActionResult AgregaroEditarPlanes(mvcPlanesModel plan)
        {
            if (plan.IdPlan == 0)
            {
                HttpResponseMessage response = WebApiClient.PostAsJsonAsync("Planes", plan).Result;
                TempData["SuccessMessage"] = "Plan Guardado.";
            }
            else
            {
                HttpResponseMessage response = WebApiClient.PutAsJsonAsync("Planes/" + plan.IdPlan, plan).Result;
                TempData["SuccessMessage"] = "Cambios Guardados.";
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = WebApiClient.DeleteAsync("Planes/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Plan Borrado.";
            return RedirectToAction("Index");
        }
    }
}