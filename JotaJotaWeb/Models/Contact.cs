using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JotaJotaWeb.Models
{
    public class Contact
    {
        [BindNever]
        public int ContactId { get; set; }

        [Required(ErrorMessage ="Este campo es requerido")]
        [StringLength(100, ErrorMessage = "Nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "El numero telefonico es requerido y debe ser de 10 digitos")]
        [Phone(ErrorMessage ="No es un formato valido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(100, ErrorMessage = "Tu correo es requerido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(5000, ErrorMessage = "Tu mensaje es requerido")]
        public string Mensaje { get; set; }
    }
}
