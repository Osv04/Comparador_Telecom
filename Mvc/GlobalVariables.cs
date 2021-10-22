using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Mvc
{
    public class GlobalVariables
    {
        public static HttpClient WebApiClient = new HttpClient();

        GlobalVariables()
        {
            WebApiClient.BaseAddress = new Uri("https://localhost:44398/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Add("Accept", "application/json;odata=verbose");

        }
    }
}