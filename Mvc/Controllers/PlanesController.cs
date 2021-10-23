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
            WebApiClient.BaseAddress = new Uri("https://localhost:44398/api/");
            IEnumerable<mvcPlanesModel> planList;
            HttpResponseMessage response = WebApiClient.GetAsync("Planes").Result;
            WebApiClient.DefaultRequestHeaders.Accept.Clear();
            WebApiClient.DefaultRequestHeaders.Add("Accept", "application/json;odata=verbose");
            planList = response.Content.ReadAsAsync<IEnumerable<mvcPlanesModel>>().Result;
            return View(planList);
        }
    }
}