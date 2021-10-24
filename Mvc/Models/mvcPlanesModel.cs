using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace Mvc.Models
{
    public class mvcPlanesModel
    {
        public int IdPlan { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string NombrePlan { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Decripcion { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public Nullable<decimal> Precio { get; set; }

        public Nullable<int> IdEmpresa { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public virtual Empresa Empresa { get; set; }
    }
}