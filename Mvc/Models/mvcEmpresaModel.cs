using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class mvcEmpresaModel
    {
        public int IdEmpresa { get; set; }

        [Required(ErrorMessage ="This field is required")]
        public string NombreEmpresa { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Direccion { get; set; }
    }
}