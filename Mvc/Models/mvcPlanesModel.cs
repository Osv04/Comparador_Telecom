using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace Mvc.Models
{
    public class mvcPlanesModel
    {
        public int IdPlan { get; set; }
        public string NombrePlan { get; set; }
        public string Decripcion { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<int> IdEmpresa { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}